using Microsoft.EntityFrameworkCore;
using Sonia.DataAccess.Context;
using Sonia.Domain.Entities;
using Sonia.Domain.Interfaces.Repositories;

namespace Sonia.DataAccess.Repositories
{
    public class PrestamoRepository : IPrestamoRepository
    {
        private readonly SoniaDbContext _context;

        public PrestamoRepository(SoniaDbContext context)
        {
            _context = context;
        }

        public async Task<Prestamo?> GetByIdAsync(int id)
        {
            return await _context.Prestamos
                .Include(x => x.Usuario)
                .Include(x => x.Ejemplar)
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<IEnumerable<Prestamo>> GetByUsuarioAsync(int usuarioId)
        {
            return await _context.Prestamos
                .Where(x => x.UsuarioId == usuarioId)
                .ToListAsync();
        }

        public async Task<Prestamo> CreateAsync(Prestamo prestamo)
        {
            _context.Prestamos.Add(prestamo);

            await _context.SaveChangesAsync();

            return prestamo;
        }

        public async Task UpdateAsync(Prestamo prestamo)
        {
            _context.Prestamos.Update(prestamo);

            await _context.SaveChangesAsync();
        }
    }
}