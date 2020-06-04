using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace HospitalNetCoreCB.Models
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<PacienteDoctor>(eb =>
                {
                    eb.HasNoKey();
                });
        }

        public DbSet<Doctor> Doctor { get; set; }
        public DbSet<Paciente> Paciente { get; set; }
        public DbSet<PacienteDoctor> PacienteDoctor { get; set; }
    }
}
