using PassaroUrbano.Domain.Entities.Oferta;

namespace PassaroUrbano.Infra.Data.Mappers.Oferta
{
    public class CategoriaMap : BaseMapping<Categoria>
    {
        public CategoriaMap() : base()
        {
            ToTable("Categoria");
        }
    }
}
