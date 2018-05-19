using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UPrime;
using YouService.Data.Services.StudyAboard;

namespace YouService.Data.Tests.Services.StudyAboard
{
    [TestClass]
    public class ArticleService_Tests:TestBase
    {
        [TestMethod]
        public void ArticleGet()
        {
            var articleService = UPrimeEngine.Instance.Resolve<IArticleService>();

            var article = articleService.GetById(1053);

            Console.WriteLine(article.SerializeToJson());

        }
    }
}
