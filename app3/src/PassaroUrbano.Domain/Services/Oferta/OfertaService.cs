using PassaroUrbano.Domain.Interfaces.Domain.Oferta;
using PassaroUrbano.Domain.Interfaces.Repositories.Oferta;

namespace PassaroUrbano.Domain.Services.Oferta
{
    public class OfertaService : BaseService<Entities.Oferta.Oferta>, IOfertaService
    {
        public OfertaService(IOfertaRepository baseRepository) : base(baseRepository)
        {
        }
    }
}
