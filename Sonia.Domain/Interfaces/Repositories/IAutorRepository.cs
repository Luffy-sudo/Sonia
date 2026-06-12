using Sonia.Domain.Entities;

namespace Sonia.Domain.Interfaces.Repositories
{
    public interface IAutorRepository
    {
        Task<Autor?> GetByIdAsync(int id);

        Task<IEnumerable<Autor>> GetAllAsync();

        Task<Autor> CreateAsync(
            Autor autor);
    }
}