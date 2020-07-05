using System.Data;

namespace PassaroUrbano.Domain.Interfaces.Repositories
{
    public interface IUnitOfWork : IDbTransaction
    {
        IDbTransaction Transaction { get; }

        void BeginTransaction();
    }
}
