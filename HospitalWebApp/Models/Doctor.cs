using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalWebApp.Models
{
    public class Doctor
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string Nombre { get; set; }

        [Display(Name = "Numero de credencial")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string NumeroCredendial { get; set; }

        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string Hospital { get; set; }
    }
}
