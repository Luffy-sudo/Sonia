using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sonia.Domain.Entities;

namespace Sonia.DataAccess.Configurations
{
    public class UsuarioConfiguration
        : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(
            EntityTypeBuilder<Usuario> entity)
        {
            entity.HasKey(x => x.Id);

            entity.Property(x => x.NumeroCuenta)
                .HasMaxLength(50)
                .IsRequired();

            entity.HasIndex(x => x.NumeroCuenta)
                .IsUnique();

            entity.Property(x => x.Nombre)
                .HasMaxLength(150)
                .IsRequired();

            entity.Property(x => x.Correo)
                .HasMaxLength(150);

            entity.HasIndex(x => x.Correo)
                .IsUnique();

            entity.HasOne(x => x.Biblioteca)
                .WithMany(x => x.Usuarios)
                .HasForeignKey(x => x.BibliotecaId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}