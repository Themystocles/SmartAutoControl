using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Controle.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Controle.Controllers
{
    public class VeiculoController : Controller
    {
        IHttpContextAccessor HttpContextAccessor;
        public VeiculoController(IHttpContextAccessor httpContextAccessor)
        {
            HttpContextAccessor = httpContextAccessor;
        }

        public IActionResult Index()
        {

            VeiculoModel objVeiculo = new VeiculoModel(HttpContextAccessor);
            ViewBag.ListaVeiculo = objVeiculo.ListaVeiculo();

            return View();
        }

        [HttpPost]
        public IActionResult NovoVeiculo(VeiculoModel formulario)
        {
            if (ModelState.IsValid)
            {
                formulario.HttpContextAccessor = HttpContextAccessor;
                formulario.Insert();
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]
        public IActionResult NovoVeiculo()
        {
            return View();
        }
        [HttpGet]
        public IActionResult ExcluirVeiculo(int id)
        {
            VeiculoModel objVeiculo = new VeiculoModel(HttpContextAccessor);
            objVeiculo.Excluir(id);

            return RedirectToAction("Index");
        }
    }
}