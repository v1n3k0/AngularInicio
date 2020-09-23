using PassaroUrbano.Domain.Entities.Oferta;
using System.Threading.Tasks;

namespace PassaroUrbano.Domain.Interfaces.Domain.Oferta
{
    public interface IOndeFicaService : IBaseService<OndeFica>
    {
        Task<OndeFica> ObterPorIdOfertaAsync(int idOferta);
    }
}
