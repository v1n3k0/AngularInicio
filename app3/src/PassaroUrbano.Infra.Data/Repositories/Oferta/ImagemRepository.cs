using PassaroUrbano.Domain.Entities.Oferta;
using PassaroUrbano.Domain.Interfaces.Repositories;
using PassaroUrbano.Domain.Interfaces.Repositories.Oferta;

namespace PassaroUrbano.Infra.Data.Repositories.Oferta
{
    public class ImagemRepository : BaseRepository<Imagem>, IImagemRepository
    {
        public ImagemRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
