using UPrime.Domain.Entities;
using UPrime.EntityFramework;
using UPrime.EntityFramework.Repositories;

namespace YouService.Data
{
    public abstract class YouServiceDataRepositoryBase<TEntity> : YouServiceDataRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        public YouServiceDataRepositoryBase(IDbContextProvider<YouServiceDataDbContext> dbContextProvider)
            : base(dbContextProvider)
        {
        }
    }

    public abstract class YouServiceDataRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<YouServiceDataDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        public YouServiceDataRepositoryBase(IDbContextProvider<YouServiceDataDbContext> dbContextProvider)
            : base(dbContextProvider)
        {
        }
    }
}
