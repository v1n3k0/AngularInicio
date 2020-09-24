using PassaroUrbano.Application.ViewModel.Oferta;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PassaroUrbano.Application.Interfaces.Oferta
{
    public interface IOfertaAppService
    {
        ObterOfertaResponseViewModel Obter(int id);
        Task<ObterOfertaResponseViewModel> ObterAsync(int id);
        IEnumerable<ObterOfertaResponseViewModel> ListarTodos();
        Task<IEnumerable<ObterOfertaResponseViewModel>> ListarTodosAsync();
        Task<IEnumerable<ObterOfertaResponseViewModel>> ListarPorCategoriaAsync(string categoria);
        Task<IEnumerable<ObterOfertaResponseViewModel>> ListarPorDestaqueAsync(bool destaque);
        Task<IEnumerable<ObterOfertaResponseViewModel>> ListarPorDescricaoAsync(string descricao);
        Task<ObterOndeFicaViewModel> ObterOndeFicaPorIdOfertaAsync(int idOferta);
        Task<ObterComoUsarViewModel> ObterComoUsarPorIdAsync(int idOferta);
        Task<IEnumerable<ObterCategoriaViewModel>> ListarTodosCategoriaAsync();
    }
}
