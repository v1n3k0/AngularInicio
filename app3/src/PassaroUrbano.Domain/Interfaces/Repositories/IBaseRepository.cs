using PassaroUrbano.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace PassaroUrbano.Domain.Interfaces.Repositories
{
    public interface IBaseRepository<T> : IDisposable where T : BaseEntity
    {
        void Adcionar(ref T entity);
        bool Atualizar(T entity);
        bool Remover(int id);
        bool Excluir(int id);
        T Obter(Expression<Func<T, bool>> predicate);
        T ObterPorId(int id);
        IEnumerable<T> ObterTodos();
        IEnumerable<T> ObterLista(Expression<Func<T, bool>> predicate);
    }
}
