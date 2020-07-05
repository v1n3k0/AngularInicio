using PassaroUrbano.Domain.Entities.Oferta;

namespace PassaroUrbano.Infra.Data.Mappers.Oferta
{
    public class ComoUsarMap : MappingBase<ComoUsar>
    {
        public ComoUsarMap()
        {
            ToTable("ComoUsar");
        }
    }
}
