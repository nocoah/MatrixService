using YouService.Data.Domain.WordBank;

namespace YouService.Data.Mappers.WordBank
{
    public partial class UWordMap : CommonEntityTypeConfigurationBase<UWord>
    {
        public UWordMap() {
            this.ToTable(DbTables.WordBank_UWords);
            this.HasKey(x => x.Id);

            this.Ignore(x => x.Type);
        }
    }
}
