using UPrime.EntityFramework;
using YouService.Data.Domain.Majors;
using YouService.Data.Domain.Majors.Repositories;

namespace YouService.Data.Repositories.Majors
{
    public class MajorRepository : YouServiceDataRepositoryBase<Major>, IMajorRepository
    {
        public MajorRepository(IDbContextProvider<YouServiceDataDbContext> dbContextProvider)
            : base(dbContextProvider)
        {
        }
    }
}

