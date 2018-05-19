using System;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using UPrime.EntityFramework;
using YouService.Data.Configuration;

namespace YouService.Data
{
    public class YouServiceCoreDbContext : UPrimeDbContext
    {
        public YouServiceCoreDbContext() : base(CoreSettings.DbConnectionString.Core)
        {
            Database.Initialize(false);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            var typesToRegister = Assembly.GetExecutingAssembly().GetTypes()
            .Where(type => !String.IsNullOrEmpty(type.Namespace))
            .Where(type => type.BaseType != null && type.BaseType.IsGenericType &&
                type.BaseType.GetGenericTypeDefinition() == typeof(CoreEntityTypeConfigurationBase<>));
            foreach (var type in typesToRegister)
            {
                dynamic configurationInstance = Activator.CreateInstance(type);
                modelBuilder.Configurations.Add(configurationInstance);
            }

            base.OnModelCreating(modelBuilder);
        }
    }


}
