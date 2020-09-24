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

        [HttpGet("ObterPorId/{idOferta}")]
        public async Task<ActionResult> ObterPorIdAsync(int idOferta)
        {
            return Ok(await _ofertaAppService.ObterAsync(idOferta));
        }

        [HttpGet("ListarTodos")]
        public async Task<ActionResult> ListarTodosAsync()
        {
            return Ok(await _ofertaAppService.ListarTodosAsync());
        }

        [HttpGet("ListarPorCategoria/{categoria}")]
        public async Task<ActionResult> ListarPorCategoriaAsync(string categoria)
        {
            return Ok(await _ofertaAppService.ListarPorCategoriaAsync(categoria));
        }

        [HttpGet("ListarPorDestaque/{destaque}")]
        public async Task<ActionResult> ListarPorDestaqueAsync(bool destaque)
        {
            return Ok(await _ofertaAppService.ListarPorDestaqueAsync(destaque));
        }

        [HttpGet("ListarPorDescricao/{descricao}")]
        public async Task<ActionResult> ListarPorDescricaoAsync(string descricao)
        {
            return Ok(await _ofertaAppService.ListarPorDescricaoAsync(descricao));
        }

        [HttpGet("{idOferta}/OndeFica")]
        public async Task<ActionResult> ObterOndeFicaPorIdOfertaAsync(int idOferta)
        {
            return Ok(await _ofertaAppService.ObterOndeFicaPorIdOfertaAsync(idOferta));
        }

        [HttpGet("{idOferta}/ComoUsar")]
        public async Task<ActionResult> ObterComoUsarPorIdAsync(int idOferta)
        {
            return Ok(await _ofertaAppService.ObterComoUsarPorIdAsync(idOferta));
        }

        [HttpGet("ListarTodosCategoria")]
        public async Task<ActionResult> ListarTodosCategoriaAsync()
        {
            return Ok(await _ofertaAppService.ListarTodosCategoriaAsync());
        }
    }
}
