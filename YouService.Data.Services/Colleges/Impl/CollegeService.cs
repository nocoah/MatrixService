using UPrime.Services.Dto;
using YouService.Data.Domain.Colleges.Repositories;

namespace YouService.Data.Services.Colleges.Impl
{
    public partial class CollegeService : ServiceBase, ICollegeService
    {
        #region Fileds & Ctor
        private readonly ICollegeCache _collegeCache;
        private readonly ICollegeRepository _collegeRepository;
        public CollegeService(ICollegeCache collegeCache, ICollegeRepository collegeRepository)
        {
            this._collegeCache = collegeCache;

            this._collegeRepository = collegeRepository;
        }

        #endregion

        #region Search / Getts
        public PagedResultDto<CollegeBriefDto> SearchColleges(CollegeSearchInput input)
        {
            return _collegeCache.SearchColleges(input);
        }

        public CollegeDto GetCollege(int collegeId)
        {
            var college =  _collegeCache.Get(collegeId);
            _collegeRepository.Update(collegeId, (x) => {
                x.Hits += 1;
            });
            return college;

        }
        #endregion
    }
}
