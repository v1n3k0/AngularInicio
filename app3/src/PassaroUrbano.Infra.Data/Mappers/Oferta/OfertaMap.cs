namespace PassaroUrbano.Infra.Data.Mappers.Oferta
{
    public class OfertaMap : MappingBase<Domain.Entities.Oferta.Oferta>
    {
        public OfertaMap()
        {
            ToTable("Oferta");

        }
    }
}
