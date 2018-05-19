using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UPrime;
using YouService.Data.Domain.WordBank.Repositories;
using YouService.Data.Domain.Colleges.Repositories;

namespace YouService.Data.Tests.Services
{
    [TestClass]
    public class Service_Tests : TestBase
    {
        [TestMethod]
        public void Should_Double_DbContext() {
            var collegeRepository = UPrimeEngine.Instance.Resolve<ICollegeRepository>();
            var uwordRepository = UPrimeEngine.Instance.Resolve<IUWordRepository>();
            

            var count2 = collegeRepository.Count();
            var count1 = uwordRepository.Count();
            

            Console.WriteLine(count1);
            Console.WriteLine(count2);
        }
    }
}
