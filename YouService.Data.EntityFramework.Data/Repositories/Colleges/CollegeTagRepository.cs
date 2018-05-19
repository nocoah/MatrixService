
using UPrime.EntityFramework;
using YouService.Data.Domain.Colleges;
using YouService.Data.Domain.Colleges.Repositories;

namespace YouService.Data.Repositories.Colleges
{
    public class CollegeTagRepository : YouServiceDataRepositoryBase<CollegeTag>, ICollegeTagRepository
    {
        public CollegeTagRepository(IDbContextProvider<YouServiceDataDbContext> dbContextProvider)
            : base(dbContextProvider)
        {
        }
    }
}
