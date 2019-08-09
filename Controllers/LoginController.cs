using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using ProAspNetCoreMvcValidation.Models;

namespace ProAspNetCoreMvcValidation.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View("Login");
        }

        [HttpPost]
        public ViewResult Logar(Usuario usuario)
        {
            if (ModelState.GetValidationState(nameof(usuario.Email)) == ModelValidationState.Valid
                && ModelState.GetValidationState(nameof(usuario.Senha)) == ModelValidationState.Valid
                && usuario.Email.Equals("alice@gmail.com", StringComparison.OrdinalIgnoreCase) 
                && usuario.Senha.Equals("123", StringComparison.OrdinalIgnoreCase))
            {
                return View("Sucesso", usuario);
            }
            else
            {
                ModelState.AddModelError("",
                    "Senha ou Usuario Incorreto");

                return View("Login");
            }
        }
    }
}