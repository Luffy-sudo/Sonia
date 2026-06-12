using Microsoft.EntityFrameworkCore;
using Sonia.DataAccess.Context;
using Sonia.Domain.Entities;
using Sonia.Domain.Interfaces.Repositories;

namespace Sonia.DataAccess.Repositories
{
    public class BibliotecaRepository : IBibliotecaRepository
    {
        private readonly SoniaDbContext _context;

        public BibliotecaRepository(SoniaDbContext context)
        {
            _context = context;
        }

        public async Task<Biblioteca?> GetByIdAsync(int id)
        {
            return await _context.Bibliotecas
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<IEnumerable<Biblioteca>> GetAllAsync()
        {
            return await _context.Bibliotecas.ToListAsync();
        }
    }
}