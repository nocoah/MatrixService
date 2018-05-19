using UPrime.EntityFramework;
using YouService.Data.Domain.Colleges;
using YouService.Data.Domain.Colleges.Repositories;

namespace YouService.Data.Repositories.Colleges
{
    public class CollegeRepository : YouServiceDataRepositoryBase<College>, ICollegeRepository
    {
        public CollegeRepository(IDbContextProvider<YouServiceDataDbContext> dbContextProvider)
            : base(dbContextProvider)
        {
        }
    }
}
