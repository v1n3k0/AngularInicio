using PassaroUrbano.Domain.Interfaces.Domain.Oferta;
using PassaroUrbano.Domain.Interfaces.Repositories;

namespace PassaroUrbano.Domain.Services.Oferta
{
    public class OfertaService : BaseService<Entities.Oferta.Oferta>, IOfertaService
    {
        public OfertaService(IBaseRepository<Entities.Oferta.Oferta> baseRepository) : base(baseRepository)
        {
        }
    }
}
