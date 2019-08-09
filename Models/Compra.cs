using ProAspNetCoreMvcValidation.Util.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProAspNetCoreMvcValidation.Models
{
    public class Compra
    {
        [Required]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [Phone]
        public string Telefone { get; set; }

        [Range(typeof(bool), "true", "true",ErrorMessage = "Informe se o número tem WhatsApp")]
        public bool NumeroComWhatsApp { get; set; }

        [Range(minimum:5, maximum:10, ErrorMessage ="Vaor Mínimo 5 e maximo 10")]
        public int Quantidade { get; set; }

        [StringLength(10)]
        public string Mensagem { get; set; }

        [MarcarComoTrue(ErrorMessage ="Voce deve marcar como true")]
        public bool TermosEntrega { get; set; }
    }
}
