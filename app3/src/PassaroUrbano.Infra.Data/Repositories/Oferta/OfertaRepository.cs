using PassaroUrbano.Domain.Interfaces.Repositories;
using PassaroUrbano.Domain.Interfaces.Repositories.Oferta;

namespace PassaroUrbano.Infra.Data.Repositories.Oferta
{
    public class OfertaRepository : BaseRepository<Domain.Entities.Oferta.Oferta>, IOfertaRepository
    {
        public OfertaRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
