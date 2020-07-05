using PassaroUrbano.Domain.Interfaces.Repositories;
using PassaroUrbano.Domain.Interfaces.Repositories.Pedido;

namespace PassaroUrbano.Infra.Data.Repositories.Pedido
{
    public class PedidoRepository : BaseRepository<Domain.Entities.Pedido.Pedido>, IPedidoRepository
    {
        public PedidoRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
