using UPrime.Domain.Entities;
using UPrime.EntityFramework;
using UPrime.EntityFramework.Repositories;

namespace YouService.Data
{
    public abstract class YouServiceCommonRepositoryBase<TEntity> : YouServiceCommonRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        public YouServiceCommonRepositoryBase(IDbContextProvider<YouServiceCommonDbContext> dbContextProvider)
            : base(dbContextProvider)
        {
        }
    }

    public abstract class YouServiceCommonRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<YouServiceCommonDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        public YouServiceCommonRepositoryBase(IDbContextProvider<YouServiceCommonDbContext> dbContextProvider)
            : base(dbContextProvider)
        {
        }
    }
}
