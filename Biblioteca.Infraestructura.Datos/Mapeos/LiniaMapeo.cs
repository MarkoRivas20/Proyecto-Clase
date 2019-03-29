using Biblioteca.Dominio.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace Biblioteca.Infraestructura.Datos.Mapeos
{
    public class LiniaMapeo : EntityTypeConfiguration<ClsLinia>
    {
        public LiniaMapeo()
        {
            ToTable("TBLINIA");
            HasKey(p => p.linea);
            Property(p => p.linea).HasColumnName("linea");
            Property(p => p.codempleado).HasColumnName("codempleado").HasMaxLength(40);
            Property(p => p.codbus).HasColumnName("codbus").HasMaxLength(40);
            Property(p => p.codruta).HasColumnName("codruta").HasMaxLength(100);
            Property(p => p.fecha).HasColumnName("fecha");
           


        }
    }
}
