using PassaroUrbano.Domain.Entities.Oferta;

namespace PassaroUrbano.Infra.Data.Mappers.Oferta
{
    public class OndeFicaMap : BaseMapping<OndeFica>
    {
        public OndeFicaMap() : base()
        {
            ToTable("OndeFica");
        }
    }
}
