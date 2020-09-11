using PassaroUrbano.Domain.Entities;
using PassaroUrbano.Domain.Interfaces.Domain;
using PassaroUrbano.Domain.Interfaces.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PassaroUrbano.Domain.Services
{
    public abstract class BaseService<T> : IBaseService<T> where T : BaseEntity
    {
        protected readonly IBaseRepository<T> _baseRepository;

        protected BaseService(IBaseRepository<T> baseRepository)
        {
            _baseRepository = baseRepository;
        }

        public T ObterPorId(int id)
        {
            return _baseRepository.ObterPorId(id);
        }

        public async Task<T> ObterPorIdAsync(int id)
        {
            return await _baseRepository.ObterPorIdAsync(id);
        }

        public IEnumerable<T> ListarTodos()
        {
            return _baseRepository.ListarTodos();
        }

        public async Task<IEnumerable<T>> ListarTodosAsync()
        {
            return await _baseRepository.ListarTodosAsync();
        }
    }
}
