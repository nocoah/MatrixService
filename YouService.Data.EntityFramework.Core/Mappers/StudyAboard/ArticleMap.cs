using YouService.Data.Domain.StudyAboard;

namespace YouService.Data.Mappers.StudyAboard
{
    public partial class ArticleMap: CoreEntityTypeConfigurationBase<Article>
    {
        public ArticleMap()
        {
            this.ToTable(DbTables.Articles);
            this.HasKey(x => x.Id);
        }
    }
}