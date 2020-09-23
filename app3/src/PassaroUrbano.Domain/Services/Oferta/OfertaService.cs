using PassaroUrbano.Domain.Enum;
using PassaroUrbano.Domain.Interfaces.Domain.Oferta;
using PassaroUrbano.Domain.Interfaces.Repositories.Oferta;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PassaroUrbano.Domain.Services.Oferta
{
    public class OfertaService : BaseService<Entities.Oferta.Oferta>, IOfertaService
    {
        private readonly IOfertaRepository _ofertaRepository;
        public OfertaService(IOfertaRepository baseRepository) : base(baseRepository)
        {
            _ofertaRepository = baseRepository;
        }

        public async Task<IEnumerable<Entities.Oferta.Oferta>> ListarPorCategoriaAsync(ECategoria eCategoria)
        {
            IEnumerable<Entities.Oferta.Oferta> response = await _baseRepository.ListarPorAsync(x => x.IdCategoria == (int)eCategoria);

            return response;
        }

        public async Task<Entities.Oferta.Oferta> ObterComComoUsarPorIdAsync(int idOferta)
        {
            Entities.Oferta.Oferta response = await _ofertaRepository.ObterComComoUsarPorIdAsync(idOferta);

            return response;
        }
    }
}
