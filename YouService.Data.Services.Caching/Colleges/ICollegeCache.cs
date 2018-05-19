using UPrime.Services.Dto;
using UPrime.Domain.Entities.Caching;

namespace YouService.Data.Services.Colleges
{
    /// <summary>
    /// 优志愿所有院校的的操作与管理服务接口(缓存化）
    /// </summary>
    public interface ICollegeCache : IEntityCache<CollegeDto>
    {
        #region Search / Getts
        /// <summary>
        /// 通过条件搜索院校
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        PagedResultDto<CollegeBriefDto> SearchColleges(CollegeSearchInput input);
        #endregion
    }
}
