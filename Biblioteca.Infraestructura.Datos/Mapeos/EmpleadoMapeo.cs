using Biblioteca.Dominio.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace Biblioteca.Infraestructura.Datos.Mapeos
{
    public class EmpleadoMapeo : EntityTypeConfiguration<ClsEmpleado>
    {
        public EmpleadoMapeo()
        {
            ToTable("TBEMPLEADO");
            HasKey(p => p.codempleado);
            Property(p => p.codempleado).HasColumnName("codempleado");
            Property(p => p.claveemp).HasColumnName("claveemp").HasMaxLength(40);
            Property(p => p.nombreemp).HasColumnName("nombreemp").HasMaxLength(40);
            Property(p => p.apellidosemp).HasColumnName("apellidosemp").HasMaxLength(100);
            Property(p => p.emailemp).HasColumnName("emailemp").HasMaxLength(9);
            Property(p => p.telefonoemp).HasColumnName("telefonoemp");
            Property(p => p.cargoemp).HasColumnName("cargoemp").HasMaxLength(10);
            Property(p => p.estadoemp).HasColumnName("estadoemp").HasMaxLength(30);
            Property(p => p.nrolicencia).HasColumnName("nrolicencia");
            Property(p => p.tipolicencia).HasColumnName("tipolicencia");
        }
    }
}
