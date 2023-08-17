using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp1.Models.Agresion;
using WinFormsApp1.Models.Extension;
using WinFormsApp1.Models.Funcion;
using WinFormsApp1.Models.Profundidad;
using WinFormsApp1.Models.Riesgo;
using WinFormsApp1.Models.Vulnerabilidad;
using System.Data.SQLite;
using Microsoft.EntityFrameworkCore;
using WinFormsApp1.Models.Sustitucion;

namespace WinFormsApp1
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(
                @"Data Source=DBDatos.db");
        }

        public DbSet<Sustitucion> Sust { get; set; }
        public DbSet<Agresion> agresion { get; set; }
        public DbSet<Extension> extension { get; set; }
        public DbSet<Funcion> funcion { get; set; }
        public DbSet<Profundidad> profundidad { get; set; }
        public DbSet<Riesgo> riesgo { get; set; }
        public DbSet<Vulnerabilidad> vuln { get; set; }
    }
}
