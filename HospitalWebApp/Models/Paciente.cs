using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalWebApp.Models
{
    public class Paciente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        
        [Display(Name = "Número de seguridad social")]
        public string NumeroSeguroSocial { get; set; }

        [Display(Name = "Codigo postal")]
        public string CodigoPostal { get; set; }

        public string Telefono { get; set; }

    }
}
