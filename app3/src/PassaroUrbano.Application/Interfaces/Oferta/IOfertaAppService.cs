using PassaroUrbano.Application.ViewModel.Oferta;
using System.Collections.Generic;

namespace PassaroUrbano.Application.Interfaces.Oferta
{
    public interface IOfertaAppService
    {
        ObterOfertaResponseViewModel Obter(int id);
        IEnumerable<ObterOfertaResponseViewModel> ListarTodos();
    }
}
