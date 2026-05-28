using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sonia.Domain.Entities;

namespace Sonia.DataAccess.Configurations
{
    public class MultaConfiguration
        : IEntityTypeConfiguration<Multa>
    {
        public void Configure(
            EntityTypeBuilder<Multa> entity)
        {
            entity.HasKey(x => x.Id);

            entity.Property(x => x.Motivo)
                .HasMaxLength(250);

            entity.HasOne(x => x.Usuario)
                .WithMany(x => x.Multas)
                .HasForeignKey(x => x.UsuarioId)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasOne(x => x.Prestamo)
                .WithMany(x => x.Multas)
                .HasForeignKey(x => x.PrestamoId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}