using Microsoft.EntityFrameworkCore;
using Sonia.DataAccess.Context;
using Sonia.Domain.Entities;
using Sonia.Domain.Interfaces.Repositories;

namespace Sonia.DataAccess.Repositories
{
    public class AutorRepository : IAutorRepository
    {
        private readonly SoniaDbContext _context;

        public AutorRepository(SoniaDbContext context)
        {
            _context = context;
        }

        public async Task<Autor?> GetByIdAsync(int id)
        {
            return await _context.Autores
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<IEnumerable<Autor>> GetAllAsync()
        {
            return await _context.Autores.ToListAsync();
        }

        public async Task<Autor> CreateAsync(Autor autor)
        {
            _context.Autores.Add(autor);

            await _context.SaveChangesAsync();

            return autor;
        }
    }
}