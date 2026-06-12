using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sonia.Domain.Entities;

namespace Sonia.DataAccess.Configurations
{
    public class PrestamoConfiguration
        : IEntityTypeConfiguration<Prestamo>
    {
        public void Configure(
            EntityTypeBuilder<Prestamo> entity)
        {
            entity.HasKey(x => x.Id);

            entity.HasOne(x => x.Usuario)
                .WithMany(x => x.Prestamos)
                .HasForeignKey(x => x.UsuarioId)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(x => x.Ejemplar)
                .WithMany(x => x.Prestamos)
                .HasForeignKey(x => x.EjemplarId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}