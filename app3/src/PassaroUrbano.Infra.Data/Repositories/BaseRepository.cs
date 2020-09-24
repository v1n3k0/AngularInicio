using Dommel;
using PassaroUrbano.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace PassaroUrbano.Infra.Data.Repositories
{
    public abstract class BaseRepository<T> : IBaseRepository<T> where T : Domain.Entities.BaseEntity
    {
        protected readonly IUnitOfWork _unitOfWork;
        private const string REGISTRONAOENCONTRADO = "Registro não encontrado";

        protected BaseRepository(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public virtual void Adicionar(T entity)
        {
            var id = _unitOfWork.Connection.Insert(entity, _unitOfWork.Transaction);

            entity.Id = (int) id;
        }

        public virtual async Task AdicionarAsync(T entity)
        {
            var id = await _unitOfWork.Connection.InsertAsync(entity, _unitOfWork.Transaction);

            entity.Id = (int)id;
        }

        public virtual bool Atualizar(T entity)
        {
            return _unitOfWork.Connection.Update(entity, _unitOfWork.Transaction);
        }

        public virtual async Task<bool> AtualizarAsync(T entity)
        {
            return await _unitOfWork.Connection.UpdateAsync(entity, _unitOfWork.Transaction);
        }

        public virtual T ObterPorId(int id)
        {
            return _unitOfWork.Connection.Get<T>(id, _unitOfWork.Transaction);
        }

        public virtual async Task<T> ObterPorIdAsync(int id)
        {
            return await _unitOfWork.Connection.GetAsync<T>(id, _unitOfWork.Transaction);
        }

        public virtual T ObterPor(Expression<Func<T, bool>> predicate)
        {
            return _unitOfWork.Connection.FirstOrDefault(predicate, _unitOfWork.Transaction);
        }

        public virtual async Task<T> ObterPorAsync(Expression<Func<T, bool>> predicate)
        {
            return await _unitOfWork.Connection.FirstOrDefaultAsync(predicate, _unitOfWork.Transaction);
        }

        public virtual bool Remover(int id)
        {
            T entity = ObterPorId(id);

            if (entity == null)
                throw new Exception(REGISTRONAOENCONTRADO);

            entity.DataRemocao = DateTime.Now;

            return _unitOfWork.Connection.Update(entity, _unitOfWork.Transaction);
        }

        public virtual async Task<bool> RemoverAsync(int id)
        {
            T entity = await ObterPorIdAsync(id);

            if (entity == null)
                throw new Exception(REGISTRONAOENCONTRADO);

            entity.DataRemocao = DateTime.Now;

            return await _unitOfWork.Connection.UpdateAsync(entity, _unitOfWork.Transaction);
        }

        public virtual bool Excluir(int id)
        {
            T entity = ObterPorId(id);

            if (entity == null)
                throw new Exception(REGISTRONAOENCONTRADO);

            return _unitOfWork.Connection.Delete(entity, _unitOfWork.Transaction);
        }

        public virtual async Task<bool> ExcluirAsync(int id)
        {
            T entity = await ObterPorIdAsync(id);

            if (entity == null)
                throw new Exception(REGISTRONAOENCONTRADO);

            return await _unitOfWork.Connection.DeleteAsync(entity, _unitOfWork.Transaction);
        }

        public virtual IEnumerable<T> ListarTodos()
        {
            return _unitOfWork.Connection.GetAll<T>(_unitOfWork.Transaction);
        }

        public virtual async Task<IEnumerable<T>> ListarTodosAsync()
        {
            return await _unitOfWork.Connection.GetAllAsync<T>(_unitOfWork.Transaction);
        }

        public virtual IEnumerable<T> ListarPor(Expression<Func<T, bool>> predicate)
        {
            return _unitOfWork.Connection.Select<T>(predicate, _unitOfWork.Transaction);
        }

        public virtual async Task<IEnumerable<T>> ListarPorAsync(Expression<Func<T, bool>> predicate)
        {
            return await _unitOfWork.Connection.SelectAsync<T>(predicate, _unitOfWork.Transaction);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing && _unitOfWork != null)
                _unitOfWork.Dispose();
        }
    }
}
