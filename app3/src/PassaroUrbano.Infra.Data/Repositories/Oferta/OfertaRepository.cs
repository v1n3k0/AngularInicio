using Dapper;
using PassaroUrbano.Domain.Entities.Oferta;
using PassaroUrbano.Domain.Interfaces.Repositories;
using PassaroUrbano.Domain.Interfaces.Repositories.Oferta;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PassaroUrbano.Infra.Data.Repositories.Oferta
{
    public class OfertaRepository : BaseRepository<Domain.Entities.Oferta.Oferta>, IOfertaRepository
    {
        public OfertaRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public async Task<Domain.Entities.Oferta.Oferta> ObterComComoUsarPorIdAsync(int idOferta)
        {
            string query = @"SELECT Oferta.*, ComoUsar.* 
              FROM ComoUsar
              LEFT JOIN Oferta ON ComoUsar.Id = Oferta.IdOndeFica
              WHERE Oferta.Id = @Id";

            IEnumerable<Domain.Entities.Oferta.Oferta> response =
                await _unitOfWork.Connection.QueryAsync<Domain.Entities.Oferta.Oferta, ComoUsar, Domain.Entities.Oferta.Oferta>(
                query,
                (oferta, comoUsar) =>
                {
                    oferta.ComoUsar = comoUsar;
                    return oferta;
                }, new { Id = idOferta }, _unitOfWork.Transaction);

            return response.FirstOrDefault();
        }
    }
}
