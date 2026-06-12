using Sonia.Domain.Entities;

namespace Sonia.Domain.Interfaces.Repositories
{
    public interface ILibroRepository
    {
        Task<Libro?> GetByISBNAsync(
            string isbn);

        Task<IEnumerable<Libro>> GetAllAsync();

        Task<Libro> CreateAsync(
            Libro libro);

        Task UpdateAsync(
            Libro libro);

        Task DeleteAsync(
            string isbn);
    }
}