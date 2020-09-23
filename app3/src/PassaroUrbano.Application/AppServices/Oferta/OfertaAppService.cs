using PassaroUrbano.Application.Interfaces.Oferta;
using PassaroUrbano.Application.ViewModel.Oferta;
using PassaroUrbano.Domain.Entities.Oferta;
using PassaroUrbano.Domain.Enum;
using PassaroUrbano.Domain.Interfaces.Domain.Oferta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PassaroUrbano.Application.AppServices.Oferta
{
    public class OfertaAppService : IOfertaAppService
    {
        private readonly IOfertaService _ofertaService;
        private readonly IOndeFicaService _ondeFicaService;

        public OfertaAppService(
            IOfertaService ofertaService,
            IOndeFicaService ondeFicaService)
        {
            _ofertaService = ofertaService;
            _ondeFicaService = ondeFicaService;
        }

        public ObterOfertaResponseViewModel Obter(int id)
        {
            Domain.Entities.Oferta.Oferta response = _ofertaService.ObterPorId(id);

            return (ObterOfertaResponseViewModel) response;
        }

        public async Task<ObterOfertaResponseViewModel> ObterAsync(int id)
        {
            Domain.Entities.Oferta.Oferta response = await _ofertaService.ObterPorIdAsync(id);

            return (ObterOfertaResponseViewModel)response;
        }

        public IEnumerable<ObterOfertaResponseViewModel> ListarTodos()
        {
            IEnumerable<Domain.Entities.Oferta.Oferta> response = _ofertaService.ListarTodos();

            return (IEnumerable<ObterOfertaResponseViewModel>)response;
        }

        public async Task<IEnumerable<ObterOfertaResponseViewModel>> ListarTodosAsync()
        {
            IEnumerable<Domain.Entities.Oferta.Oferta> response = await _ofertaService.ListarTodosAsync();

            return response.Select(x => (ObterOfertaResponseViewModel)x);
        }

        public async Task<IEnumerable<ObterOfertaResponseViewModel>> ListarPorCategoriaAsync(string categoria)
        {
            Enum.TryParse(categoria, true, out ECategoria eCategoria);

            IEnumerable<Domain.Entities.Oferta.Oferta> response = await _ofertaService.ListarPorCategoriaAsync(eCategoria);

            return response.Select(x => (ObterOfertaResponseViewModel)x);
        }

        public async Task<OndeFicaViewModel> ObterOndeFicaPorIdOfertaAsync(int idOferta)
        {
            OndeFica response = await _ondeFicaService.ObterPorIdOfertaAsync(idOferta);

            return (OndeFicaViewModel)response;
        }

        public async Task<ComoUsarViewModel> ObterComoUsarPorIdAsync(int idOferta)
        {
            var response = await _ofertaService.ObterComComoUsarPorIdAsync(idOferta);

            return (ComoUsarViewModel)response.ComoUsar;
        }
    }
}
