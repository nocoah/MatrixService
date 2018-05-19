using System.Reflection;
using UPrime;
using UPrime.Modules;

namespace YouService.Data.Services
{
    [DependsOn(typeof(UPrimeAutoMapperModule))]
    public class YouServiceDataServicesDtoModule : UPrimeModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
