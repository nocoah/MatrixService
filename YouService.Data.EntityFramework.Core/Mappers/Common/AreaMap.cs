using YouService.Data.Domain.Common;

namespace YouService.Data.Mappers.WordBank
{
    public partial class AreaMap : CoreEntityTypeConfigurationBase<Area>
    {
        public AreaMap()
        {
            this.ToTable(DbTables.Common_Areas);
            this.HasKey(x => x.Id);

            this.Property(x => x.Name).HasColumnName("AreaName");
            this.Property(x => x.TypeId).HasColumnName("Level");
            
            this.Ignore(x => x.Type);
        }
    }
}
