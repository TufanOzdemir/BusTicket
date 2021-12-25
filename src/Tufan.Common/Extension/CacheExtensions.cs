using Tufan.Common.Caching;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Tufan.Common.Extension
{
    public static class CacheExtensions
    {
        /// <summary>
        /// Michaco Cache yapısını ayağa kaldırır.
        /// </summary>
        /// <param name="services"></param>
        /// <param name="configuration"></param>
        /// <returns></returns>
        public static IServiceCollection AddCacheManagerService(this IServiceCollection services, IConfiguration configuration)
        {
            var cacheManagerFactory = new CacheManagerFactory(configuration);
            cacheManagerFactory.Initialize();
            services.AddSingleton<ICacheManagerFactory>(cacheManagerFactory);
            return services;
        }
    }
}