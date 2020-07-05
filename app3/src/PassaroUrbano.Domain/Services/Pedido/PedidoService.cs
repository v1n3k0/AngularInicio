using PassaroUrbano.Domain.Interfaces.Domain.Pedido;
using PassaroUrbano.Domain.Interfaces.Repositories;

namespace PassaroUrbano.Domain.Services.Pedido
{
    public class PedidoService : BaseService<Entities.Pedido.Pedido>, IPedidoService
    {
        public PedidoService(IBaseRepository<Entities.Pedido.Pedido> baseRepository) : base(baseRepository)
        {
        }
    }
}
