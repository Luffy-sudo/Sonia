using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sonia.Domain.Entities;

namespace Sonia.DataAccess.Configurations
{
    public class EjemplarConfiguration
        : IEntityTypeConfiguration<Ejemplar>
    {
        public void Configure(
            EntityTypeBuilder<Ejemplar> entity)
        {
            entity.HasKey(x => x.Id);

            entity.Property(x => x.CodigoBarras)
                .HasMaxLength(100)
                .IsRequired();

            entity.HasIndex(x => x.CodigoBarras)
                .IsUnique();

            entity.Property(x => x.UbicacionFisica)
                .HasMaxLength(150);

            entity.HasOne(x => x.Libro)
                .WithMany(x => x.Ejemplares)
                .HasForeignKey(x => x.LibroISBN);

            entity.HasOne(x => x.Biblioteca)
                .WithMany(x => x.Ejemplares)
                .HasForeignKey(x => x.BibliotecaId);
        }
    }
}