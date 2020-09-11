using PassaroUrbano.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PassaroUrbano.Domain.Interfaces.Domain
{
    public interface IBaseService<T> where T : BaseEntity
    {
        T ObterPorId(int id);
        Task<T> ObterPorIdAsync(int id);
        IEnumerable<T> ListarTodos();
        Task<IEnumerable<T>> ListarTodosAsync();
    }
}
