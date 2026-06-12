using Sonia.Domain.Entities;
using Sonia.Domain.Interfaces.Repositories;

namespace Sonia.Application.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _repository;

        public UsuarioService(
            IUsuarioRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Usuario>>
            GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<Usuario?>
            GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task<Usuario>
            CreateAsync(Usuario usuario)
        {
            var existing =
                await _repository.GetByNumeroCuentaAsync(
                    usuario.NumeroCuenta);

            if (existing != null)
            {
                throw new InvalidOperationException(
                    "Ya existe un usuario con ese número de cuenta");
            }

            return await _repository.CreateAsync(usuario);
        }

        public async Task UpdateAsync(
            int id,
            Usuario usuario)
        {
            var existing =
                await _repository.GetByIdAsync(id);

            if (existing == null)
            {
                throw new KeyNotFoundException(
                    $"Usuario {id} no encontrado");
            }

            usuario.Id = id;

            await _repository.UpdateAsync(usuario);
        }

        public async Task DeleteAsync(int id)
        {
            var existing =
                await _repository.GetByIdAsync(id);

            if (existing == null)
            {
                throw new KeyNotFoundException(
                    $"Usuario {id} no encontrado");
            }

            await _repository.DeleteAsync(id);
        }
    }
}