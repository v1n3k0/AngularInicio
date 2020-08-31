using PassaroUrbano.Domain.Entities.Oferta;

namespace PassaroUrbano.Infra.Data.Mappers.Oferta
{
    public class ComoUsarMap : BaseMapping<ComoUsar>
    {
        public ComoUsarMap() : base()
        {
            ToTable("ComoUsar");
        }
    }
}
