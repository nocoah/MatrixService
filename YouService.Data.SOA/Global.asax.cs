using Castle.Facilities.Logging;
using Newtonsoft.Json.Serialization;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using UPrime;
using UPrime.Castle.Log4Net;
using UPrime.Utils;
using YouService.Data.SOA.Startup;


namespace YouService.Data.SOA
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            //序列化Api的响应Dto
            var serializerSettings = GlobalConfiguration.Configuration.Formatters.JsonFormatter.SerializerSettings;
            var contractResolver = (DefaultContractResolver)serializerSettings.ContractResolver;
            contractResolver.IgnoreSerializableAttribute = true;

            UPrimeStarter.Create<YouServiceDataSOAModule>(
            (options) => {
                options.IocManager.IocContainer.AddFacility<LoggingFacility>(
                   f => f.UseUpLog4Net().WithConfig(WebHelper.MapPath("/log4net.config"))
               );
            }
            ).Initialize();
        }
    }
}
