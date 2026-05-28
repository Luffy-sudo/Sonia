using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sonia.Domain.Entities;

namespace Sonia.DataAccess.Configurations
{
    public class BibliotecaConfiguration
        : IEntityTypeConfiguration<Biblioteca>
    {
        public void Configure(
            EntityTypeBuilder<Biblioteca> entity)
        {
            entity.HasKey(x => x.Id);

            entity.Property(x => x.Nombre)
                .HasMaxLength(200)
                .IsRequired();

            entity.Property(x => x.Direccion)
                .HasMaxLength(250);

            entity.Property(x => x.Telefono)
                .HasMaxLength(20);

            entity.Property(x => x.Ciudad)
                .HasMaxLength(100);
        }
    }
}