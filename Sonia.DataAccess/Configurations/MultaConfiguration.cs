using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sonia.Domain.Entities;

namespace Sonia.DataAccess.Configurations
{
    public class MultaConfiguration
        : IEntityTypeConfiguration<Multa>
    {
        public void Configure(
            EntityTypeBuilder<Multa> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.DiasRetraso)
                .IsRequired();

            builder.Property(x => x.DiasSuspension)
                .IsRequired();

            builder.Property(x => x.FechaGeneracion)
                .IsRequired();

            builder.Property(x => x.Activa)
                .IsRequired();

            builder.HasOne(x => x.Usuario)
                .WithMany(x => x.Multas)
                .HasForeignKey(x => x.UsuarioId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(x => x.Prestamo)
                .WithMany(x => x.Multas)
                .HasForeignKey(x => x.PrestamoId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}