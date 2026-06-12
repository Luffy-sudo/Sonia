using Microsoft.EntityFrameworkCore;
using Sonia.DataAccess.Context;
using Sonia.Domain.Entities;
using Sonia.Domain.Interfaces.Repositories;

namespace Sonia.DataAccess.Repositories
{
    public class LibroRepository : ILibroRepository
    {
        private readonly SoniaDbContext _context;

        public LibroRepository(SoniaDbContext context)
        {
            _context = context;
        }

        public async Task<Libro?> GetByISBNAsync(string isbn)
        {
            return await _context.Libros
                .Include(x => x.LibroAutores)
                .FirstOrDefaultAsync(x => x.ISBN == isbn);
        }

        public async Task<IEnumerable<Libro>> GetAllAsync()
        {
            return await _context.Libros.ToListAsync();
        }

        public async Task<Libro> CreateAsync(Libro libro)
        {
            _context.Libros.Add(libro);

            await _context.SaveChangesAsync();

            return libro;
        }

        public async Task UpdateAsync(Libro libro)
        {
            _context.Libros.Update(libro);

            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(string isbn)
        {
            var libro = await _context.Libros.FindAsync(isbn);

            if (libro != null)
            {
                _context.Libros.Remove(libro);

                await _context.SaveChangesAsync();
            }
        }
    }
}