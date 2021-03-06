﻿using PassaroUrbano.Domain.Entities.Oferta;
using System.Threading.Tasks;

namespace PassaroUrbano.Domain.Interfaces.Repositories.Oferta
{
    public interface IOndeFicaRepository : IBaseRepository<OndeFica>
    {
        Task<OndeFica> ObterPorIdOfertaAsync(int idOferta);
    }
}
