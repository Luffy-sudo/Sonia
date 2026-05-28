using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Sonia.Domain.Entities;

namespace Sonia.DataAccess.Configurations
{
    public class LibroAutorConfiguration
        : IEntityTypeConfiguration<LibroAutor>
    {
        public void Configure(
            EntityTypeBuilder<LibroAutor> entity)
        {
            entity.HasKey(x => new
            {
                x.LibroISBN,
                x.AutorId
            });

            entity.HasOne(x => x.Libro)
                .WithMany(x => x.LibroAutores)
                .HasForeignKey(x => x.LibroISBN);

            entity.HasOne(x => x.Autor)
                .WithMany(x => x.LibroAutores)
                .HasForeignKey(x => x.AutorId);
        }
    }
}