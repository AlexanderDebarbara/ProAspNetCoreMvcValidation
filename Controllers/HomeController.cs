using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using ProAspNetCoreMvcValidation.Models;

namespace ProAspNetCoreMvcValidation.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View("Agenda", new Compromisso { Data = DateTime.Now });
        }

        [HttpPost]
        public ViewResult Agenda(Compromisso compromisso)
        {
            if (string.IsNullOrEmpty(compromisso.NomeCliente))
            {
                ModelState.AddModelError(nameof(compromisso.NomeCliente), "Informe Seu Nome");
            }

            if (ModelState.GetValidationState("Data") == ModelValidationState.Valid && DateTime.Now > compromisso.Data)
            {
                ModelState.AddModelError(nameof(compromisso.Data), "Informe uma data futura");
            }

            if (!compromisso.AceitaTermos)
            {
                ModelState.AddModelError(nameof(compromisso.AceitaTermos), "Voce deve aceitar os termos");
            }

            if (ModelState.IsValid)
            {
                return View("Completo", compromisso);
            }
            else
            {
                return View();
            }
        }
    }
}