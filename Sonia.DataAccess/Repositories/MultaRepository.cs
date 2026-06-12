using Microsoft.EntityFrameworkCore;
using Sonia.DataAccess.Context;
using Sonia.Domain.Entities;
using Sonia.Domain.Interfaces.Repositories;

namespace Sonia.DataAccess.Repositories
{
    public class MultaRepository : IMultaRepository
    {
        private readonly SoniaDbContext _context;

        public MultaRepository(SoniaDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Multa>> GetByUsuarioAsync(int usuarioId)
        {
            return await _context.Multas
                .Where(x => x.UsuarioId == usuarioId)
                .ToListAsync();
        }

        public async Task<Multa> CreateAsync(Multa multa)
        {
            _context.Multas.Add(multa);

            await _context.SaveChangesAsync();

            return multa;
        }
    }
}