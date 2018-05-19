using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UPrime;
using YouService.Data.Domain.WordBank.Repositories;
using YouService.Data.Services.Colleges;
using YouService.Data.Domain.Colleges.Repositories;

namespace YouService.Data.Tests.Services.Colleges
{
    [TestClass]
    public class CollegeService_Tests : TestBase
    {
        [TestMethod]
        public void Should_College_Get_Search() {
            var collegeService = UPrimeEngine.Instance.Resolve<ICollegeService>();
            var college = collegeService.GetCollege(1053);
            Console.WriteLine(college.SerializeToJson());

            var college2 = collegeService.GetCollege(1053);

            var a = 1;
        }

        [TestMethod]
        public void Repository_CURD() {
            var collegeRepository = UPrimeEngine.Instance.Resolve<ICollegeRepository>();
            var college = collegeRepository.Get(1053);
            var a = 1;
        }
    }
}
