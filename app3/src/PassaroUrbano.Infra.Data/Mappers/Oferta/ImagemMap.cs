using PassaroUrbano.Domain.Entities.Oferta;

namespace PassaroUrbano.Infra.Data.Mappers.Oferta
{
    public class ImagemMap : BaseMapping<Imagem>
    {
        public ImagemMap() : base()
        {
            ToTable("Imagem");
        }
    }
}
