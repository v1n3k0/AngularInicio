using PassaroUrbano.Domain.Enum;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PassaroUrbano.Domain.Interfaces.Domain.Oferta
{
    public interface IOfertaService : IBaseService<Entities.Oferta.Oferta>
    {
        Task<IEnumerable<Entities.Oferta.Oferta>> ListarPorCategoriaAsync(ECategoria eCategoria);
        Task<Entities.Oferta.Oferta> ObterComComoUsarPorIdAsync(int idOferta);
    }
}
