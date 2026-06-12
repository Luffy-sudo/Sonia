using Sonia.Domain.Entities;

namespace Sonia.Domain.Interfaces.Repositories
{
    public interface IBibliotecaRepository
    {
        Task<Biblioteca?> GetByIdAsync(int id);

        Task<IEnumerable<Biblioteca>> GetAllAsync();
    }
}