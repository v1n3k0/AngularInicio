using PassaroUrbano.Domain.Entities;
using PassaroUrbano.Domain.Interfaces.Domain;
using PassaroUrbano.Domain.Interfaces.Repositories;
using System.Collections.Generic;

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

        public IEnumerable<T> ObterTodos()
        {
            return _baseRepository.ListarTodos();
        }

        public bool Remover(int id)
        {
            return _baseRepository.Remover(id);
        }
    }
}
