using System;
using CacheManager.Core;
using EFSecondLevelCache.Core;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;

namespace DotNetScaffolder.Domain.Data.Contexts.EFCore.Base
{
    public class ConfigureServices
    {
        #region Public Methods And Operators

        public static IServiceProvider GetInMemoryCacheServiceProvider()
        {
            var services = new ServiceCollection();
            services.AddEFSecondLevelCache();

            AddInMemoryCacheServiceProvider(services);

            return services.BuildServiceProvider();
        }

        public static IServiceProvider GetRedisCacheServiceProvider()
        {
            var services = new ServiceCollection();
            services.AddEFSecondLevelCache();

            AddRedisCacheServiceProvider(services);

            return services.BuildServiceProvider();
        }

        #endregion

        #region Other Methods

        private static void AddInMemoryCacheServiceProvider(IServiceCollection services)
        {
            services.AddSingleton(typeof(ICacheManagerConfiguration),
                new ConfigurationBuilder()
                    .WithJsonSerializer()
                    .WithMicrosoftMemoryCacheHandle()
                    .WithExpiration(ExpirationMode.Absolute, TimeSpan.FromMinutes(10))
                    .DisablePerformanceCounters()
                    .DisableStatistics()
                    .Build());
            services.AddSingleton(typeof(ICacheManager<>), typeof(BaseCacheManager<>));
        }

        private static void AddRedisCacheServiceProvider(IServiceCollection services)
        {
            // Add Redis cache service provider
            var jss = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };

            const string redisConfigurationKey = "redis";
            services.AddSingleton(typeof(ICacheManagerConfiguration),
                new ConfigurationBuilder()
                    .WithJsonSerializer(jss, jss)
                    .WithUpdateMode(CacheUpdateMode.Up)
                    .WithRedisConfiguration(redisConfigurationKey, config =>
                    {
                        config.WithAllowAdmin()
                            .WithEndpoint("localhost", 6379);
                    })
                    .WithMaxRetries(100)
                    .WithRetryTimeout(50)
                    .WithRedisCacheHandle(redisConfigurationKey)
                    .WithExpiration(ExpirationMode.Absolute, TimeSpan.FromMinutes(10))
                    .Build());
            services.AddSingleton(typeof(ICacheManager<>), typeof(BaseCacheManager<>));
        }

        #endregion
    }
}