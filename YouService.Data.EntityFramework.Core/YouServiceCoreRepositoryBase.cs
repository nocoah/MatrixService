using UPrime.Domain.Entities;
using UPrime.EntityFramework;
using UPrime.EntityFramework.Repositories;


namespace YouService.Data
{
    public abstract class YouServiceCoreRepositoryBase<TEntity> : YouServiceCoreRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        public YouServiceCoreRepositoryBase(IDbContextProvider<YouServiceCoreDbContext> dbContextProvider)
            : base(dbContextProvider)
        {
        }
    }

    public abstract class YouServiceCoreRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<YouServiceCoreDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        public YouServiceCoreRepositoryBase(IDbContextProvider<YouServiceCoreDbContext> dbContextProvider)
            : base(dbContextProvider)
        {
        }
    }

}


