using System.Collections.Generic;
using System.Linq;
using UPrime.AutoMapper;
using UPrime.Dependency;
using UPrime.Domain.Entities.Caching;
using UPrime.Events.Bus.Entities;
using UPrime.Services.Dto;
using YouService.Data.Domain.Colleges;
using YouService.Data.Domain.Colleges.Repositories;

namespace YouService.Data.Services.Colleges.Impl
{
    public class CollegeCache : EntityCache<College, CollegeDto>, ICollegeCache, ITransientDependency
    {
        #region Keys
        public const string KEY_SearchColleges = "SearchColleges-{0}";
        #endregion

        public CollegeCache(ICacheManagerProvider cacheManagerProvider, ICollegeRepository repository)
        : base(cacheManagerProvider.GetCacheManager(), repository, "College")
        {

        }

        #region Search / Getts
        public PagedResultDto<CollegeBriefDto> SearchColleges(CollegeSearchInput input) {
            return null;
        }
        #endregion

        public override void HandleEvent(EntityChangedEventData<College> eventData)
        {
            base.HandleEvent(eventData);
            //InternalCache.InternalCache.RemoveAsync(GET_BY_KEY.FormatWith(eventData.Entity.StoreKey));
        }
    }
}
