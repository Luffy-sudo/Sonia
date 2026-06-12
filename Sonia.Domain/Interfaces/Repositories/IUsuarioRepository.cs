using Sonia.Domain.Entities;

namespace Sonia.Domain.Interfaces.Repositories
{
    public interface IUsuarioRepository
    {
        Task<Usuario?> GetByIdAsync(int id);

        Task<Usuario?> GetByNumeroCuentaAsync(
            string numeroCuenta);

        Task<IEnumerable<Usuario>> GetAllAsync();

        Task<Usuario> CreateAsync(
            Usuario usuario);

        Task UpdateAsync(
            Usuario usuario);

        Task DeleteAsync(
            int id);
    }
}