using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Controle.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Controle.Controllers
{
    public class ServiçoController : Controller
    {
        IHttpContextAccessor HttpContextAccessor;
        public ServiçoController(IHttpContextAccessor httpContextAccessor)
        {
            HttpContextAccessor = httpContextAccessor;
        }

        public IActionResult Index()
        {

            ServiçoModel objServiço = new ServiçoModel(HttpContextAccessor);
            ViewBag.ListaServiço = objServiço.ListaServiço();

            return View();
        }

        [HttpPost]
        public IActionResult NovoServiço(ServiçoModel formulario)
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
        public IActionResult NovoServiço(int? Ids)
        {
            if(Ids != null)
            {
                ServiçoModel objServiçoModel = new ServiçoModel(HttpContextAccessor);
                ViewBag.Registro = objServiçoModel.CarregarRegistro(Ids);
            }
            return View();
        }
        [HttpGet]
        public IActionResult ExcluirServiço(int id)
        {
            ServiçoModel objServiço = new ServiçoModel(HttpContextAccessor);
            objServiço.Excluir(id);

            return RedirectToAction("Index");
        }
    }
}