using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalNetCoreCB.Models
{
    public class Doctor
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string NumeroCredendial { get; set; }
        public string Hospital { get; set; }
    }
}
