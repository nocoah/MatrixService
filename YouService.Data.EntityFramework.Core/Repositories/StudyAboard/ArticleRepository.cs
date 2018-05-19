using UPrime.EntityFramework;
using YouService.Data.Domain.StudyAboard;
using YouService.Data.Domain.StudyAboard.Repositories;

namespace YouService.Data.Repositories.StudyAboard
{
    public class ArticleRepository: YouServiceCoreRepositoryBase<Article>, IArticleRepository
    {
        public ArticleRepository(IDbContextProvider<YouServiceCoreDbContext> dbContextProvider)
            : base(dbContextProvider)
        {
        }
    }
}

