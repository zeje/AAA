using System.Web.Mvc;

namespace AAA.Web.Controllers
{
    public class AboutController : AAAControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}