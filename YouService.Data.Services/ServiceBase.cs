using UPrime;
using UPrime.Dependency;
using UPrime.Runtime.Caching;
using UPrime.Services;

namespace YouService.Data.Services
{
    /// <summary>
    /// 所有应用服务的基类，实现类必须继承此类
    /// </summary>
    public abstract class ServiceBase : ApplicationServiceBase, ITransientDependency
    {
        protected readonly ICacheManager CacheManager;
        public ServiceBase()
        {
            CacheManager = UPrimeEngine.Instance.Resolve<ICacheManagerProvider>().GetCacheManager();
        }
    }
}
