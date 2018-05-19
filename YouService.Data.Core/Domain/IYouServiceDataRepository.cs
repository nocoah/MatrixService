using UPrime.Domain.Repositories;
using UPrime.Domain.Entities;

namespace YouService.Data.Domain
{
    public interface IYouServiceDataRepository<TEntity> : IYouServiceDataRepository<TEntity, int>
        where TEntity : class, IEntity<int>
    {

    }

    public interface IYouServiceDataRepository<TEntity, TPrimaryKey> : IRepository<TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
    }
}
