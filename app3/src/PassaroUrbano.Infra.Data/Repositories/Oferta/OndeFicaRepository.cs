using PassaroUrbano.Domain.Entities.Oferta;
using PassaroUrbano.Domain.Interfaces.Repositories;
using PassaroUrbano.Domain.Interfaces.Repositories.Oferta;

namespace PassaroUrbano.Infra.Data.Repositories.Oferta
{
    public class OndeFicaRepository : BaseRepository<OndeFica>, IOndeFicaRepository
    {
        public OndeFicaRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }
    }
}
