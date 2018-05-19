using System.Reflection;
using UPrime;
using UPrime.Modules;
using UPrime.Utils;
using YouService.Data.Services;


namespace YouService.Data.SOA.Startup
{
    [DependsOn(typeof(UPrimeLeadershipModule),
               typeof(UPrimeEntityFrameworkModule),
               typeof(UPrimeAutoMapperModule),
               typeof(YouServiceDataCoreModule),
               typeof(YouServiceDataEntityFrameworkDataModule),
               typeof(YouServiceDataEntityFrameworkCommonModule),
               typeof(YouServiceDataServicesDtoModule),
               typeof(YouServiceDataServicesCachingModule),
               typeof(YouServiceDataServicesModule))
        ]
    public class YouServiceDataSOAModule : UPrimeModule
    {
        public override void PreInitialize()
        {
            Configuration.DefaultSettingsPath = WebHelper.MapPath("/Config/YouService.Data/");
        }

        public override void Initialize()
        {
            IocManager.RegisterAssembly(Assembly.GetExecutingAssembly());
        }
    }
}