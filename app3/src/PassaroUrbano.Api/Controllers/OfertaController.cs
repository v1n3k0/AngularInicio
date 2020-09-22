using Microsoft.AspNetCore.Mvc;
using PassaroUrbano.Application.Interfaces.Oferta;
using System.Threading.Tasks;

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

        [HttpGet("ObterPorId/{id}")]
        public async Task<ActionResult> ObterPorIdAsync(int id)
        {
            return Ok(await _ofertaAppService.ObterAsync(id));
        }

        [HttpGet("ListarTodosAsync")]
        public async Task<ActionResult> ListarTodosAsync()
        {
            return Ok(await _ofertaAppService.ListarTodosAsync());
        }

        [HttpGet("ListarPorCategoria/{categoria}")]
        public async Task<ActionResult> ListarPorCategoriaAsync(string categoria)
        {
            return Ok(await _ofertaAppService.ListarPorCategoriaAsync(categoria));
        }
    }
}
