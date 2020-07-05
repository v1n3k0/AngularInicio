using PassaroUrbano.Application.Interfaces.Oferta;
using PassaroUrbano.Application.ViewModel.Oferta;
using PassaroUrbano.Domain.Interfaces.Domain.Oferta;
using System.Collections.Generic;

namespace PassaroUrbano.Application.AppServices.Oferta
{
    public class OfertaAppService : IOfertaAppService
    {
        private readonly IOfertaService _ofertaService;
        public OfertaAppService(IOfertaService ofertaService)
        {
            _ofertaService = ofertaService;
        }

        public ObterOfertaResponseViewModel Obter(int id)
        {
            Domain.Entities.Oferta.Oferta response = _ofertaService.ObterPorId(id);

            return (ObterOfertaResponseViewModel) response;
        }

        public IEnumerable<ObterOfertaResponseViewModel> ObterTodos()
        {
            IEnumerable<Domain.Entities.Oferta.Oferta> response = _ofertaService.ObterTodos();

            return (IEnumerable<ObterOfertaResponseViewModel>)response;
        }

        public bool Remover(int id)
        {
            bool response = _ofertaService.Remover(id);

            return response;
        }
    }
}
