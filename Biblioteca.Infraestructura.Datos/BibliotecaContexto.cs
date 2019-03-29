using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca.Dominio.Entidades;
using System.Data.Entity;
using Biblioteca.Infraestructura.Datos.Mapeos;

namespace Biblioteca.Infraestructura.Datos
{
    class BibliotecaContexto : DbContext
    {
        public BibliotecaContexto() : base("BDRuta")
        {
        }
        public DbSet<ClsBus> Bus { get; set; }
        public DbSet<ClsEmpleado> Empleados { get; set; }
        public DbSet<ClsLinia> Linias { get; set; }
        public DbSet<ClsRuta> Rutas { get; set; }
       


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Configurations.Add(new BusMapeo());
            modelBuilder.Configurations.Add(new EmpleadoMapeo());
            modelBuilder.Configurations.Add(new LiniaMapeo());
            modelBuilder.Configurations.Add(new RutaMapeo());
            
        }
    }
}
