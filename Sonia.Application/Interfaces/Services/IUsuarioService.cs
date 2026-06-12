using Sonia.Domain.Entities;

namespace Sonia.Application.Services
{
    public interface IUsuarioService
    {
        Task<Usuario?> GetByIdAsync(int id);

        Task<IEnumerable<Usuario>> GetAllAsync();

        Task<Usuario> CreateAsync(
            Usuario usuario);

        Task UpdateAsync(
            int id,
            Usuario usuario);

        Task DeleteAsync(
            int id);
    }
}