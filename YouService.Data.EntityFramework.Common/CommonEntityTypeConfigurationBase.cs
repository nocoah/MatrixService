using System.Data.Entity.ModelConfiguration;

namespace YouService.Data
{
    public abstract class CommonEntityTypeConfigurationBase<T> : EntityTypeConfiguration<T> where T : class
    {
        protected CommonEntityTypeConfigurationBase()
        {
            PostInitialize();
        }

        protected virtual void PostInitialize()
        {

        }
    }
}
