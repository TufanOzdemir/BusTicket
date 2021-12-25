using CacheManager.Core;
using Tufan.Common.Const;
using Microsoft.Extensions.Configuration;
using System.Collections.Concurrent;

namespace Tufan.Common.Caching
{
    public class CacheManagerFactory : ICacheManagerFactory
    {
        private readonly IConfiguration _configuration;
        private static ConcurrentDictionary<string, ICacheManagerService> _configurations;

        public CacheManagerFactory(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void Initialize()
        {
            _configurations = new ConcurrentDictionary<string, ICacheManagerService>();
            _configurations.TryAdd(ConstVariables.Caching.CommonCacheConfigurationKey, new CacheManagerService(GetCacheManager(ConstVariables.Caching.CommonCacheConfigurationKey)));
            _configurations.TryAdd(ConstVariables.Caching.LongDurationMemoryConfigurationKey, new CacheManagerService(GetCacheManager(ConstVariables.Caching.LongDurationMemoryConfigurationKey)));
            _configurations.TryAdd(ConstVariables.Caching.SmallDurationCacheConfigurationKey, new CacheManagerService(GetCacheManager(ConstVariables.Caching.SmallDurationCacheConfigurationKey)));
        }

        public ICacheManagerService GetCacheManagerService(string key)
        {
            _configurations.TryGetValue(key, out var cacheManagerService);
            return cacheManagerService;
        }

        private ICacheManager<object> GetCacheManager(string key) => CacheFactory.FromConfiguration<object>(key, _configuration.GetCacheConfiguration(key));
    }
}