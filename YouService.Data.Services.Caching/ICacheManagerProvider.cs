using UPrime.Runtime.Caching;

namespace YouService.Data.Services
{
    public interface ICacheManagerProvider
    {
        ICacheManager GetCacheManager();
    }
}
