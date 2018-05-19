using YouService.Data.Domain.Colleges;

namespace YouService.Data.Mappers.Colleges
{
    public partial class CollegeTagMap : DataEntityTypeConfigurationBase<CollegeTag>
    {
        public CollegeTagMap()
        {
            this.ToTable(DbTables.Colleges_Tags);
            this.HasKey(x => x.Id);

            this.Property(x => x.Name).HasColumnName("TagName");
            this.Property(x => x.TypeId).HasColumnName("TagType");

            this.Ignore(x => x.Type);
        }
    }
}
