using Microsoft.EntityFrameworkCore;
using Sonia.Domain.Entities;

namespace Sonia.DataAccess.Context
{
    public class SoniaDbContext : DbContext
    {
        public SoniaDbContext(
            DbContextOptions<SoniaDbContext> options)
            : base(options)
        {
        }

        public DbSet<Usuario> Usuarios => Set<Usuario>();

        public DbSet<Biblioteca> Bibliotecas => Set<Biblioteca>();

        public DbSet<Libro> Libros => Set<Libro>();

        public DbSet<Autor> Autores => Set<Autor>();

        public DbSet<LibroAutor> LibroAutores => Set<LibroAutor>();

        public DbSet<Ejemplar> Ejemplares => Set<Ejemplar>();

        public DbSet<Prestamo> Prestamos => Set<Prestamo>();

        public DbSet<Multa> Multas => Set<Multa>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(
                typeof(SoniaDbContext).Assembly);
        }
    }
}