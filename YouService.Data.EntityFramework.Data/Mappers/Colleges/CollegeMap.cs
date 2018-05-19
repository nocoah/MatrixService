using YouService.Data.Domain.Colleges;

namespace YouService.Data.Mappers.Colleges
{
    public partial class CollegeMap : DataEntityTypeConfigurationBase<College>
    {
        public CollegeMap() {
            this.ToTable(DbTables.Colleges);
            this.HasKey(x => x.Id);
            this.HasRequired(x => x.Province).WithMany().HasForeignKey(x => x.ProvinceId);

            this.Property(x => x.IsDeleted).HasColumnName("Deleted");
        }
    }
}
