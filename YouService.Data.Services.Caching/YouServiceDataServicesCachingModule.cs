using System.Reflection;
using UPrime;
using UPrime.Configuration.Startup;
using UPrime.Dependency;
using UPrime.Modules;
using UPrime.Runtime.Caching.Redis;

namespace YouService.Data.Services
{
    [DependsOn(
        typeof(UPrimeRedisCacheModule),
        typeof(YouServiceDataCoreModule),
        typeof(YouServiceDataServicesDtoModule)
        )]
    public class YouServiceDataServicesCachingModule : UPrimeModule
    {
        public override void PreInitialize()
        {
            Configuration.ReplaceService<IUPrimeRedisCacheDatabaseProvider, CurrentRedisCacheDatabaseProvider>(DependencyLifeStyle.Singleton);
            Configuration.Caching.UseRedis();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
