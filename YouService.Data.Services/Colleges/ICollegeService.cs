using UPrime.Services.Dto;

namespace YouService.Data.Services.Colleges
{
    /// <summary>
    /// 优志愿所有院校的的操作与管理服务接口
    /// </summary>
    public interface ICollegeService
    {
        #region Search / Getts
        /// <summary>
        /// 通过条件搜索院校
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        PagedResultDto<CollegeBriefDto> SearchColleges(CollegeSearchInput input);

        /// <summary>
        /// 通过院校Id获取院校信息
        /// </summary>
        /// <param name="collegeId"></param>
        /// <returns></returns>
        CollegeDto GetCollege(int collegeId);
        #endregion
    }
}
