using Sonia.Domain.Entities;

namespace Sonia.Domain.Interfaces.Repositories
{
    public interface IMultaRepository
    {
        Task<IEnumerable<Multa>>
            GetByUsuarioAsync(int usuarioId);

        Task<Multa> CreateAsync(
            Multa multa);
    }
}