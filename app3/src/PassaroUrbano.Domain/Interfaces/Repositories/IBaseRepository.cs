using PassaroUrbano.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace PassaroUrbano.Domain.Interfaces.Repositories
{
    public interface IBaseRepository<T> : IDisposable where T : BaseEntity
    {
        void Adicionar(T entity);
        Task AdicionarAsync(T entity);
        bool Atualizar(T entity);
        Task<bool> AtualizarAsync(T entity);
        T ObterPorId(int id);
        Task<T> ObterPorIdAsync(int id);
        T ObterPor(Expression<Func<T, bool>> predicate);
        Task<T> ObterPorAsync(Expression<Func<T, bool>> predicate);
        bool Remover(int id);
        Task<bool> RemoverAsync(int id);
        bool Excluir(int id);
        Task<bool> ExcluirAsync(int id);
        IEnumerable<T> ListarTodos();
        Task<IEnumerable<T>> ListarTodosAsync();
        IEnumerable<T> ListarPor(Expression<Func<T, bool>> predicate);
        Task<IEnumerable<T>> ListarPorAsync(Expression<Func<T, bool>> predicate);
    }
}
