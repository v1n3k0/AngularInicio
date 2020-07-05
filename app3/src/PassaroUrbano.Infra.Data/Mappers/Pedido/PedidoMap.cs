namespace PassaroUrbano.Infra.Data.Mappers.Pedido
{
    public class PedidoMap : MappingBase<Domain.Entities.Pedido.Pedido>
    {
        public PedidoMap()
        {
            ToTable("Pedido");
        }
    }
}
