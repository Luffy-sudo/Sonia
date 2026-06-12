using Microsoft.EntityFrameworkCore;
using Sonia.DataAccess.Context;
using Sonia.Domain.Entities;
using Sonia.Domain.Interfaces.Repositories;

namespace Sonia.DataAccess.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly SoniaDbContext _context;

        public UsuarioRepository(
            SoniaDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Usuario>>
            GetAllAsync()
        {
            return await _context.Usuarios
                .Include(x => x.Biblioteca)
                .ToListAsync();
        }

        public async Task<Usuario?>
            GetByIdAsync(int id)
        {
            return await _context.Usuarios
                .Include(x => x.Biblioteca)
                .FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Usuario?>
            GetByNumeroCuentaAsync(
                string numeroCuenta)
        {
            return await _context.Usuarios
                .FirstOrDefaultAsync(
                    x => x.NumeroCuenta == numeroCuenta);
        }

        public async Task<Usuario>
            CreateAsync(Usuario usuario)
        {
            _context.Usuarios.Add(usuario);

            await _context.SaveChangesAsync();

            return usuario;
        }

        public async Task UpdateAsync(
            Usuario usuario)
        {
            _context.Usuarios.Update(usuario);

            await _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(
            int id)
        {
            var usuario =
                await _context.Usuarios.FindAsync(id);

            if (usuario != null)
            {
                _context.Usuarios.Remove(usuario);

                await _context.SaveChangesAsync();
            }
        }
    }
}