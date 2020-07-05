using PassaroUrbano.Domain.Entities.Oferta;

namespace PassaroUrbano.Infra.Data.Mappers.Oferta
{
    public class OndeFicaMap : MappingBase<OndeFica>
    {
        public OndeFicaMap()
        {
            ToTable("OndeFica");
        }
    }
}
