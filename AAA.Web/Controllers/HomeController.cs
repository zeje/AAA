using System.Web.Mvc;

namespace AAA.Web.Controllers
{
    public class HomeController : AAAControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}