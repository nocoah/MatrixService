using Castle.Facilities.Logging;
using System.Reflection;
using System.Data.Entity;
using UPrime;
using UPrime.Castle.Log4Net;
using UPrime.Modules;
using YouService.Data;
using YouService.Data.Services;

namespace YouService.Data.Tests
{
    public abstract class TestBase
    {
        public TestBase() {
            UPrimeStarter.Create<YouServiceDataTestsModule>(
            (options) => {
                options.IocManager.IocContainer.AddFacility<LoggingFacility>(
                   f => f.UseUpLog4Net().WithConfig("log4net.config")
               );
            }
            ).Initialize();
        }
    }

    [DependsOn(typeof(UPrimeLeadershipModule),
               typeof(UPrimeEntityFrameworkModule),
               typeof(UPrimeAutoMapperModule),
               typeof(UPrimeSDKModule),
               typeof(YouServiceDataCoreModule),
               typeof(YouServiceDataEntityFrameworkCommonModule),
               typeof(YouServiceDataEntityFrameworkDataModule),
               typeof(YouServiceDataEntityFrameworkCoreModule),
               typeof(YouServiceDataServicesDtoModule),
               typeof(YouServiceDataServicesCachingModule),
               typeof(YouServiceDataServicesModule)
               )
        ]
    public class YouServiceDataTestsModule : UPrimeModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<YouServiceDataDbContext>(null);
            //Configuration.DefaultSettingsPath = AppDomain.CurrentDomain.BaseDirectory.ConcatWith("\\Config\\Current\\");
        }

        public override void Initialize()
        {
            IocManager.RegisterAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
