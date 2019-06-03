using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Controle.Models;
using Microsoft.AspNetCore.Http;

namespace Controle.Controllers
{
    public class HomeController : Controller
    {
        public IHttpContextAccessor HttpContextAccessor { get; }

        public IActionResult Index()
        {
            HomeModel objHomeModel = new HomeModel();
            string nome = objHomeModel.LerNomeUsuario();
            ViewData["Nome"] = nome;


            return View();
        }

        public HomeController(IHttpContextAccessor httpContextAccessor)
        {

            HttpContextAccessor = httpContextAccessor;
        }
        public IActionResult Lembretes()
        {
            LembretesModel objLembrete = new LembretesModel(HttpContextAccessor);
            ViewBag.ListaLembretes = objLembrete.ListaLembretes();

            return View();

            
        }

        public IActionResult Contact()
        {
            EstoqueModel objEstoque = new EstoqueModel(HttpContextAccessor);
            ViewBag.ListaEstoque = objEstoque.ListaEstoque();

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult Menu()
        {
            return View();
        }







        public IActionResult NovoLembrete(LembretesModel formulario)
        {
            if (ModelState.IsValid)
            {
                formulario.HttpContextAccessor = HttpContextAccessor;
                formulario.Insert();
                return RedirectToAction("Lembretes");
            }
            return View();
        }
        [HttpGet]
        public IActionResult NovoLembrete()
        {
            return View();
        }

        public IActionResult ExcluirLembrete(int id)
        {
            LembretesModel objLembrete = new LembretesModel(HttpContextAccessor);
            objLembrete.Excluir(id);

            return RedirectToAction("Lembretes");
        }








        public IActionResult NovoEstoque(EstoqueModel formulario)
        {
            if (ModelState.IsValid)
            {
                formulario.HttpContextAccessor = HttpContextAccessor;
                formulario.Insert();
                return RedirectToAction("contact");
            }
            return View();
        }
        [HttpGet]
        public IActionResult NovoEstoque()
        {
            return View();
        }

        public IActionResult ExcluirEstoque(int id)
        {
            EstoqueModel objestoque = new EstoqueModel(HttpContextAccessor);
            objestoque.Excluir(id);

            return RedirectToAction("contact");
        }

        public IActionResult Mais(EstoqueModel formulario)
        {

            if (ModelState.IsValid)
            {
                formulario.HttpContextAccessor = HttpContextAccessor;
                formulario.Insert();
                return RedirectToAction("contact");
            }
            return View();



            return View();
        }
    }
}

