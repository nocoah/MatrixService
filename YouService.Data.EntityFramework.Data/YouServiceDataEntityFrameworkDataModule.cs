using System.Reflection;
using UPrime;
using UPrime.Modules;

namespace YouService.Data
{
    [DependsOn(typeof(UPrimeEntityFrameworkModule))]
    public class YouServiceDataEntityFrameworkDataModule : UPrimeModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
