using Dommel;
using Microsoft.Extensions.Caching.Memory;
using PassaroUrbano.Domain.Entities.Oferta;
using PassaroUrbano.Domain.Interfaces.Repositories;
using PassaroUrbano.Domain.Interfaces.Repositories.Oferta;
using PassaroUrbano.Infra.Cache;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PassaroUrbano.Infra.Data.Repositories.Oferta
{
    public class CategoriaRepository : BaseRepository<Categoria>, ICategoriaRepository
    {
        private readonly IMemoryCache _cache;

        public CategoriaRepository(
            IUnitOfWork unitOfWork,
            CustomMemoryCache cache) : base(unitOfWork)
        {
            _cache = cache.Cache;
        }

        public override async Task<IEnumerable<Categoria>> ListarTodosAsync()
        {
            var cacheKey = "Categoria";

            var response = await _cache.GetOrCreateAsync(cacheKey, async entry =>
            {
                entry.SlidingExpiration = TimeSpan.FromSeconds(30);
                entry.AbsoluteExpiration = DateTimeOffset.Now.AddSeconds(600);
                entry.Size = 1024;

                return await _unitOfWork.Connection.GetAllAsync<Categoria>(_unitOfWork.Transaction);
            });

            return response;
        }
    }
}
