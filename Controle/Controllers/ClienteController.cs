using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using Controle.ConexãoBD;
using Controle.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Controle.Controllers
{
    public class ClienteController : Controller
    {
        IHttpContextAccessor HttpContextAccessor;
        public ClienteController(IHttpContextAccessor httpContextAccessor)
        {
            HttpContextAccessor = httpContextAccessor;
        }

        public IActionResult Index()
        {

            ClienteModel objCliente = new ClienteModel(HttpContextAccessor);
            ViewBag.ListaCliente = objCliente.ListaCliente();
            
            return View();
        }

        public IActionResult Relatorio()
        {
            RelatorioModel objRelatorio = new RelatorioModel(HttpContextAccessor);
           ViewBag.ListaRelatorio = objRelatorio.ListaRelatorio();

            

            return View();
        }
        
        [HttpGet]
        [HttpPost]
        public IActionResult Relatorio(RelatorioModel formulario)
            {

            formulario.HttpContextAccessor = HttpContextAccessor;
            ViewBag.ListaRelatorio = formulario.ListaRelatorio();
            ViewBag.ListaCliente = new ClienteModel(HttpContextAccessor).ListaCliente();
            
            
        

            return View();
        }
        [HttpPost]
        public IActionResult NovoCliente(ClienteModel formulario)
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
        public IActionResult NovoCliente()
        {
            return View();
        }

        public IActionResult ExcluirCliente(int id)
        {
            ClienteModel objCliente = new ClienteModel(HttpContextAccessor);
            objCliente.Excluir(id);

            return RedirectToAction("Index");
        }
    }
}