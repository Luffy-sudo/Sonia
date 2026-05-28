using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sonia.Domain.Entities;

namespace Sonia.DataAccess.Configurations
{
    public class AutorConfiguration
        : IEntityTypeConfiguration<Autor>
    {
        public void Configure(
            EntityTypeBuilder<Autor> entity)
        {
            entity.HasKey(x => x.Id);

            entity.Property(x => x.Nombre)
                .HasMaxLength(150)
                .IsRequired();

            entity.Property(x => x.Nacionalidad)
                .HasMaxLength(100);
        }
    }
}