using UPrime;
using UPrime.Dependency;
using UPrime.Runtime.Caching;
using UPrime.Runtime.Caching.Memory;
using UPrime.Runtime.Caching.Redis;
using YouService.Data.Configuration;

namespace YouService.Data.Services
{
    /// <summary>
    /// 根据配置文件返回CacheManager的提供
    /// Redis或内存
    /// </summary>
    public class CurrentRedisCacheManagerProvider : ICacheManagerProvider, ITransientDependency
    {
        public ICacheManager GetCacheManager()
        {
            if (CoreSettings.CachingOpened)
            {
                if (CoreSettings.RedisEnabled)
                {
                    return UPrimeEngine.Instance.Resolve<UPrimeRedisCacheManager>();
                }
                else
                {
                    return UPrimeEngine.Instance.Resolve<UPrimeMemoryCacheManager>();
                }
            }
            else
            {
                return UPrimeEngine.Instance.Resolve<NullCacheManager>();
            }
        }
    }
}
