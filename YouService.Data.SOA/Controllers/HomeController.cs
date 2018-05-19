using System.Web.Mvc;

namespace YouService.Data.SOA.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index() {
            return Redirect("/swagger");
        }
    }
}