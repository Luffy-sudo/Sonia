using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sonia.Domain.Entities;

namespace Sonia.DataAccess.Configurations
{
    public class LibroConfiguration
        : IEntityTypeConfiguration<Libro>
    {
        public void Configure(
            EntityTypeBuilder<Libro> entity)
        {
            entity.HasKey(x => x.ISBN);

            entity.Property(x => x.ISBN)
                .HasMaxLength(20);

            entity.Property(x => x.Titulo)
                .HasMaxLength(300)
                .IsRequired();

            entity.Property(x => x.Editorial)
                .HasMaxLength(150);

            entity.Property(x => x.ClasificacionDewey)
                .HasMaxLength(50);

            entity.Property(x => x.Coleccion)
                .HasMaxLength(150);
        }
    }
}