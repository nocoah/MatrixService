using System.Reflection;
using UPrime;
using UPrime.Modules;
using UPrime.Utils;

namespace YouService.Data
{
    [DependsOn(typeof(UPrimeLeadershipModule))]
    public class YouServiceDataCoreModule : UPrimeModule
    {
        public override void PreInitialize()
        {
            Configuration.DefaultSettingsPath = WebHelper.MapPath("/Config/");
        }
        public override void Initialize()
        {
            IocManager.RegisterAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
