namespace PassaroUrbano.Infra.Data.Mappers.Oferta
{
    public class OfertaMap : BaseMapping<Domain.Entities.Oferta.Oferta>
    {
        public OfertaMap() : base()
        {
            ToTable("Oferta");

        }
    }
}
