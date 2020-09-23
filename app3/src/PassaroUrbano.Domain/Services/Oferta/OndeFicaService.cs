using PassaroUrbano.Domain.Entities.Oferta;
using PassaroUrbano.Domain.Interfaces.Domain.Oferta;
using PassaroUrbano.Domain.Interfaces.Repositories.Oferta;
using System.Threading.Tasks;

namespace PassaroUrbano.Domain.Services.Oferta
{
    public class OndeFicaService : BaseService<OndeFica>, IOndeFicaService
    {
        private readonly IOndeFicaRepository _ondeFicaRepository;

        public OndeFicaService(IOndeFicaRepository baseRepository) : base(baseRepository)
        {
            _ondeFicaRepository = baseRepository;
        }

        public async Task<OndeFica> ObterPorIdOfertaAsync(int idOferta)
        {
            var response = await _ondeFicaRepository.ObterPorIdOfertaAsync(idOferta);

            return response;
        }

    }
}
