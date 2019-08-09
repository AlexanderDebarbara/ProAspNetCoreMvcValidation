using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProAspNetCoreMvcValidation.Models
{
    public class Usuario
    {
        [Required(ErrorMessage = "Infome o Email")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Informe a Senha")]
        public string Senha { get; set; }
    }
}
