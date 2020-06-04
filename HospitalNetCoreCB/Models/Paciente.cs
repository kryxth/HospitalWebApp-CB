using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalNetCoreCB.Models
{
    public class Paciente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string NumeroSeguroSocial { get; set; }
        public string CodigoPostal { get; set; }
        public string Telefono { get; set; }

    }
}
