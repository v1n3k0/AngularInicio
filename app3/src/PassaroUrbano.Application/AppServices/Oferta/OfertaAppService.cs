using PassaroUrbano.Application.Interfaces.Oferta;
using PassaroUrbano.Application.ViewModel.Oferta;
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
        public OfertaAppService(IOfertaService ofertaService)
        {
            _ofertaService = ofertaService;
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

    }
}
