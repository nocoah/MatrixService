using System.Data.Entity.ModelConfiguration;

namespace YouService.Data
{
    public abstract class DataEntityTypeConfigurationBase<T> : EntityTypeConfiguration<T> where T : class
    {
        protected DataEntityTypeConfigurationBase()
        {
            
            PostInitialize();
        }

        protected virtual void PostInitialize()
        {

        }
    }
}
