using Microsoft.AspNetCore.Mvc;
using PassaroUrbano.Application.Interfaces.Oferta;
using PassaroUrbano.Application.ViewModel.Oferta;

namespace PassaroUrbano.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OfertaController : ControllerBase
    {
        private readonly IOfertaAppService _ofertaAppService;
        public OfertaController(IOfertaAppService ofertaAppService)
        {
            _ofertaAppService = ofertaAppService;
        }

        [HttpGet]
        public ObterOfertaResponseViewModel Get(int id)
        {
            return _ofertaAppService.Obter(id);
        }
    }
}
