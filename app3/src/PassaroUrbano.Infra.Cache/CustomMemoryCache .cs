using Microsoft.Extensions.Caching.Memory;

namespace PassaroUrbano.Infra.Cache
{
    public class CustomMemoryCache
    {
        public MemoryCache Cache { get; set; }
        public CustomMemoryCache()
        {
            Cache = new MemoryCache(new MemoryCacheOptions
            {
                //2MB
                SizeLimit = 2048
            });
        }
    }
}
