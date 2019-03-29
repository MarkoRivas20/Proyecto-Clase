
using Biblioteca.Dominio.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace Biblioteca.Infraestructura.Datos.Mapeos
{
    public class RutaMapeo: EntityTypeConfiguration<ClsRuta>
    {
        public RutaMapeo()
        {
            ToTable("TBRUTA");
            HasKey(p => p.codruta);
            Property(p => p.codruta).HasColumnName("codruta");
            Property(p => p.rutaltdlng).HasColumnName("rutaltdlng").HasMaxLength(11);
        
        

        }
    }
}
