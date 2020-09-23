using Dapper;
using PassaroUrbano.Domain.Entities.Oferta;
using PassaroUrbano.Domain.Interfaces.Repositories;
using PassaroUrbano.Domain.Interfaces.Repositories.Oferta;
using System.Threading.Tasks;

namespace PassaroUrbano.Infra.Data.Repositories.Oferta
{
    public class OndeFicaRepository : BaseRepository<OndeFica>, IOndeFicaRepository
    {
        public OndeFicaRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public async Task<OndeFica> ObterPorIdOfertaAsync(int idOferta)
        {
            string query = @"SELECT * 
              FROM OndeFica
              LEFT JOIN Oferta ON OndeFica.Id = Oferta.IdOndeFica
              WHERE Oferta.Id = @Id";

            var response = await _unitOfWork.Connection.QueryFirstAsync<OndeFica>(query, new { Id = idOferta }, _unitOfWork.Transaction);

            return response;
        }
    }
}
