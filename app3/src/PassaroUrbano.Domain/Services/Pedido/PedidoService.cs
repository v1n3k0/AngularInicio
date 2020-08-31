using PassaroUrbano.Domain.Interfaces.Domain.Pedido;
using PassaroUrbano.Domain.Interfaces.Repositories.Pedido;

namespace PassaroUrbano.Domain.Services.Pedido
{
    public class PedidoService : BaseService<Entities.Pedido.Pedido>, IPedidoService
    {
        public PedidoService(IPedidoRepository baseRepository) : base(baseRepository)
        {
        }
    }
}
