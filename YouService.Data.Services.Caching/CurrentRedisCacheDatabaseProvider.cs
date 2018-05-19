using StackExchange.Redis;
using System;
using UPrime.Dependency;
using UPrime.Runtime.Caching.Redis;
using YouService.Data.Configuration;

namespace YouService.Data.Services
{
    /// <summary>
    /// 使用自定义的配置
    /// </summary>
    public class CurrentRedisCacheDatabaseProvider : IUPrimeRedisCacheDatabaseProvider, ISingletonDependency
    {
        private readonly Lazy<ConnectionMultiplexer> _connectionMultiplexer;


        public CurrentRedisCacheDatabaseProvider()
        {
            _connectionMultiplexer = new Lazy<ConnectionMultiplexer>(CreateConnectionMultiplexer);
        }

        /// <summary>
        ///获取数据库连接
        /// </summary>
        public IDatabase GetDatabase()
        {
            return _connectionMultiplexer.Value.GetDatabase(CoreSettings.RedisDatabaseId);
        }

        private ConnectionMultiplexer CreateConnectionMultiplexer()
        {
            return ConnectionMultiplexer.Connect(CoreSettings.RedisConnectionString);
        }
    }
}
