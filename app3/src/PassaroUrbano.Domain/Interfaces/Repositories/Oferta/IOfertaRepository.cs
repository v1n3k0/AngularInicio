using System.Threading.Tasks;

namespace PassaroUrbano.Domain.Interfaces.Repositories.Oferta
{
    public interface IOfertaRepository : IBaseRepository<Entities.Oferta.Oferta>
    {
        Task<Entities.Oferta.Oferta> ObterComComoUsarPorIdAsync(int idOferta);
    }
}
