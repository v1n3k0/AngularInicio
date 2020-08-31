using Dommel;
using PassaroUrbano.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

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

        public void Adcionar(ref T entity)
        {
            var id = _unitOfWork.Connection.Insert(entity, _unitOfWork.Transaction);

            entity.Id = (int) id;
        }

        public bool Atualizar(T entity)
        {
            return _unitOfWork.Connection.Update(entity, _unitOfWork.Transaction);
        }

        public bool Excluir(int id)
        {
            T entity = ObterPorId(id);

            if (entity == null)
                throw new Exception(REGISTRONAOENCONTRADO);

            return _unitOfWork.Connection.Delete(entity, _unitOfWork.Transaction);
        }

        public T Obter(Expression<Func<T, bool>> predicate)
        {
            return _unitOfWork.Connection.FirstOrDefault(predicate, _unitOfWork.Transaction);
        }

        public IEnumerable<T> ObterLista(Expression<Func<T, bool>> predicate)
        {
            return _unitOfWork.Connection.Select<T>(predicate, _unitOfWork.Transaction);
        }

        public T ObterPorId(int id)
        {
            return _unitOfWork.Connection.Get<T>(id, _unitOfWork.Transaction);
        }

        public IEnumerable<T> ObterTodos()
        {
            return _unitOfWork.Connection.GetAll<T>(_unitOfWork.Transaction);
        }

        public bool Remover(int id)
        {
            T entity = ObterPorId(id);

            if (entity == null)
                throw new Exception(REGISTRONAOENCONTRADO);

            entity.DataRemocao = DateTime.Now;

            return _unitOfWork.Connection.Update(entity, _unitOfWork.Transaction);
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
