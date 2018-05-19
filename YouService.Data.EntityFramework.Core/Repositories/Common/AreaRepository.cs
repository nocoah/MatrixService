using UPrime.EntityFramework;
using YouService.Data.Domain.Common;
using YouService.Data.Domain.Common.Repositories;

namespace YouService.Data.Repositories.Common
{
    public class AreaRepository : YouServiceCoreRepositoryBase<Area>, IAreaRepository
    {
        public AreaRepository(IDbContextProvider<YouServiceCoreDbContext> dbContextProvider)
            : base(dbContextProvider)
        {
        }
    }
}
