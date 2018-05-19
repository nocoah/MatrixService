using UPrime.EntityFramework;
using YouService.Data.Domain.WordBank;
using YouService.Data.Domain.WordBank.Repositories;

namespace YouService.Data.Repositories.WordBank
{
    public class UWordRepository : YouServiceCommonRepositoryBase<UWord>, IUWordRepository
    {
        public UWordRepository(IDbContextProvider<YouServiceCommonDbContext> dbContextProvider)
            : base(dbContextProvider)
        {
        }
    }
}
