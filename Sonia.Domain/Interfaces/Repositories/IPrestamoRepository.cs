using Sonia.Domain.Entities;

namespace Sonia.Domain.Interfaces.Repositories
{
    public interface IPrestamoRepository
    {
        Task<Prestamo?> GetByIdAsync(int id);

        Task<IEnumerable<Prestamo>>
            GetByUsuarioAsync(int usuarioId);

        Task<Prestamo> CreateAsync(
            Prestamo prestamo);

        Task UpdateAsync(
            Prestamo prestamo);
    }
}