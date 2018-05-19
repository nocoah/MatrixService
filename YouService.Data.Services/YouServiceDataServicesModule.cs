using System.Reflection;
using UPrime.Modules;

namespace YouService.Data.Services
{

    [DependsOn(
        typeof(YouServiceDataCoreModule),
        typeof(YouServiceDataServicesDtoModule),
        typeof(YouServiceDataServicesCachingModule))
        ]
    public class YouServiceDataServicesModule : UPrimeModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
