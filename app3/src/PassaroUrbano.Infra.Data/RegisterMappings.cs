using Dapper.FluentMap;
using Dapper.FluentMap.Dommel;
using PassaroUrbano.Infra.Data.Mappers.Oferta;
using PassaroUrbano.Infra.Data.Mappers.Pedido;

namespace PassaroUrbano.Infra.Data
{
    public static class RegisterMappings
    {
        public static void Register()
        {
            FluentMapper.Initialize(config =>
            {
                //Oferta
                config.AddMap(new OfertaMap());
                config.AddMap(new CategoriaMap());
                config.AddMap(new ComoUsarMap());
                config.AddMap(new OndeFicaMap());
                config.AddMap(new ImagemMap());

                //Pedido
                config.AddMap(new PedidoMap());

                config.ForDommel();
            });
        }
    }
}
