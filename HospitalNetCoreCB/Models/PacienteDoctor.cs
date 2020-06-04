using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HospitalNetCoreCB.Models
{
    public class PacienteDoctor
    {
        public Paciente Paciente { get; set; }
        public Doctor Doctor { get; set; }

        

    }

}
