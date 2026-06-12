using Sonia.Domain.Entities;

namespace Sonia.Domain.Interfaces.Repositories
{
    public interface IEjemplarRepository
    {
        Task<Ejemplar?> GetByIdAsync(int id);

        Task<IEnumerable<Ejemplar>>
            GetByLibroAsync(string isbn);

        Task<Ejemplar> CreateAsync(
            Ejemplar ejemplar);

        Task UpdateAsync(
            Ejemplar ejemplar);

        Task DeleteAsync(
            int id);
    }
}