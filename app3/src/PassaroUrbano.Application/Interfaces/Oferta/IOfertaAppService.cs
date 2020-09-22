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
    }
}
