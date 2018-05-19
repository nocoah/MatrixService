using System.Data.Entity.ModelConfiguration;

namespace YouService.Data
{
    public abstract class EntityTypeConfigurationBase<T> : EntityTypeConfiguration<T> where T : class
    {
        protected EntityTypeConfigurationBase()
        {
            PostInitialize();
        }

        protected virtual void PostInitialize()
        {

        }
    }
}
