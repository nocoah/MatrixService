using System.Data.Entity.ModelConfiguration;

namespace YouService.Data
{
    public abstract class CoreEntityTypeConfigurationBase<T> : EntityTypeConfiguration<T> where T : class
    {
        protected CoreEntityTypeConfigurationBase()
        {
            PostInitialize();
        }

        protected virtual void PostInitialize()
        {

        }
    }
}
