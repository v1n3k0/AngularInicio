using System;
using System.Data;
using PassaroUrbano.Domain.Interfaces.Repositories;

namespace PassaroUrbano.Infra.Data.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        public Guid IdTrasaction { get; set; }
        public IDbConnection Connection { get; } = null;
        public IDbTransaction Transaction { get; private set; } = null;
        public IsolationLevel IsolationLevel => throw new System.NotImplementedException();

        private bool disposed = false;

        public UnitOfWork(IDbConnection connection)
        {
            Connection = connection;
            Connection.Open();
            IdTrasaction = Guid.NewGuid();
        }

        public void BeginTransaction()
        {
            if (Transaction == null)
                Transaction = Connection.BeginTransaction();
        }

        public void Commit()
        {
            if (Transaction != null && Transaction.Connection != null)
                Transaction.Commit();
        }

        public void Rollback()
        {
            if (Transaction != null && Transaction.Connection != null)
                Transaction.Rollback();
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed && disposing && Transaction != null)
            {
                Transaction.Dispose();

                Connection.Close();
                Connection.Dispose();
            }

            disposed = true;
        }

    }
}
