using Microsoft.EntityFrameworkCore;
using Sonia.DataAccess.Context;
using Sonia.Domain.Entities;
using Sonia.Domain.Interfaces.Repositories;

namespace Sonia.DataAccess.Repositories
{
    public class EjemplarRepository : IEjemplarRepository
    {
        private readonly SoniaDbContext _context;

        public EjemplarRepository(SoniaDbContext context)
        {
            _context = context;
        }

        public async Task<Ejemplar?> GetByIdAsync(int id)
        {
            return await _context.Ejemplares
                .Include(x => x.Libro)
                .Include(x => x.Biblioteca)
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<IEnumerable<Ejemplar>> GetByLibroAsync(string isbn)
        {
            return await _context.Ejemplares
                .Where(x => x.LibroISBN == isbn)
                .ToListAsync();
        }

        public async Task<Ejemplar> CreateAsync(Ejemplar ejemplar)
        {
            _context.Ejemplares.Add(ejemplar);

            await _context.SaveChangesAsync();

            return ejemplar;
        }

        public async Task UpdateAsync(Ejemplar ejemplar)
        {
            _context.Ejemplares.Update(ejemplar);

            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var ejemplar = await _context.Ejemplares.FindAsync(id);

            if (ejemplar != null)
            {
                _context.Ejemplares.Remove(ejemplar);

                await _context.SaveChangesAsync();
            }
        }
    }
}