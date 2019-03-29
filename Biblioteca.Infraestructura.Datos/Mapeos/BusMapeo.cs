using Biblioteca.Dominio.Entidades;
using System.Data.Entity.ModelConfiguration;

namespace Biblioteca.Infraestructura.Datos.Mapeos
{
    public class BusMapeo : EntityTypeConfiguration<ClsBus>
    {
        public BusMapeo()
        {
            ToTable("TBBUS");
            HasKey(p => p.Placa);
            Property(p => p.Placa).HasColumnName("Placa");
            Property(p => p.Tamaño).HasColumnName("Tamaño").HasMaxLength(6);
            Property(p => p.Capacidad).HasColumnName("Capacidad");
            Property(p => p.Fecha).HasColumnName("Fecha").HasMaxLength(11);
            Property(p => p.Estado).HasColumnName("Estado ").HasMaxLength(3);
            Property(p => p.linea).HasColumnName("linea").HasMaxLength(8);
           
            
            
        }
    }
}
