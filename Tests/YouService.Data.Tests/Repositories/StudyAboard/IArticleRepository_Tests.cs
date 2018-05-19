using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UPrime;
using YouService.Data.Domain.StudyAboard.Repositories;

namespace YouService.Data.Tests.Repositories.StudyAboard
{
    [TestClass]
    public class IArticleRepository_Tests : TestBase
    {
        [TestMethod]
        public void Should_CURD() {
            var repository = UPrimeEngine.Instance.Resolve<IArticleRepository>();
            var count = repository.Count();
            Console.WriteLine(count);
        }
    }
}
