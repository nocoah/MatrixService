using System.Linq;
using UPrime.AutoMapper;
using UPrime.Dependency;
using UPrime.Domain.Entities.Caching;
using UPrime.Events.Bus.Entities;
using YouService.Data.Domain.Majors;
using YouService.Data.Domain.Majors.Repositories;

namespace YouService.Data.Services.Majors.Impl
{
    public class MajorCache : EntityCache<Major, MajorDto>, IMajorCache, ITransientDependency
    {
        #region Keys
        public const string KEY_GetMajorByCode = "GetMajorByCode-{0}";
        #endregion
        public MajorCache(ICacheManagerProvider cacheManagerProvider, IMajorRepository repository)
      : base(cacheManagerProvider.GetCacheManager(), repository, "Major")
        {

        }
        /// <summary>
        /// 根据code查询专业信息,因为现在都是用MajorCode匹配,所以Id只是用来做修改什么的操作了
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        public MajorDto GetMajorByCode(string code)
        {
            return InternalCache.InternalCache.Get(KEY_GetMajorByCode, (key) => {
                var major = this.Repository.FirstOrDefault(x => x.Code == code);
                return major.MapTo<MajorDto>();
            }) as MajorDto;
        }

        public override void HandleEvent(EntityChangedEventData<Major> eventData)
        {
            base.HandleEvent(eventData);
            eventData.Entity.IfNotNull(() =>
            {
                InternalCache.InternalCache.Remove(KEY_GetMajorByCode.FormatWith(eventData.Entity.Code));
            });
        }
    }
}
