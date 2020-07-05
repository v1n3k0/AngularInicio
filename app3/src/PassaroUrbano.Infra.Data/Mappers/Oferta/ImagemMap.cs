using PassaroUrbano.Domain.Entities.Oferta;

namespace PassaroUrbano.Infra.Data.Mappers.Oferta
{
    public class ImagemMap : MappingBase<Imagem>
    {
        public ImagemMap()
        {
            ToTable("Imagem");
        }
    }
}
