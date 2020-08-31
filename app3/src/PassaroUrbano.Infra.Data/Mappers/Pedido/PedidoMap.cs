namespace PassaroUrbano.Infra.Data.Mappers.Pedido
{
    public class PedidoMap : BaseMapping<Domain.Entities.Pedido.Pedido>
    {
        public PedidoMap() : base()
        {
            ToTable("Pedido");
        }
    }
}
