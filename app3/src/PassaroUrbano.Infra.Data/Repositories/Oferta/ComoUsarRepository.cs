using PassaroUrbano.Domain.Entities.Oferta;
using PassaroUrbano.Domain.Interfaces.Repositories;
using PassaroUrbano.Domain.Interfaces.Repositories.Oferta;

namespace PassaroUrbano.Infra.Data.Repositories.Oferta
{
    public class ComoUsarRepository : BaseRepository<ComoUsar>, IComoUsarRepository
    {
        public ComoUsarRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
