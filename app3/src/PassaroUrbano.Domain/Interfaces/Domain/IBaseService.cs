using PassaroUrbano.Domain.Entities;
using System.Collections.Generic;

namespace PassaroUrbano.Domain.Interfaces.Domain
{
    public interface IBaseService<T> where T : BaseEntity
    {
        T ObterPorId(int id);
        IEnumerable<T> ObterTodos();
        bool Remover(int id);
    }
}
