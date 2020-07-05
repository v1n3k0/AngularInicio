using PassaroUrbano.Domain.Entities.Oferta;

namespace PassaroUrbano.Infra.Data.Mappers.Oferta
{
    public class CategoriaMap : MappingBase<Categoria>
    {
        public CategoriaMap()
        {
            ToTable("Categoria");
        }
    }
}
