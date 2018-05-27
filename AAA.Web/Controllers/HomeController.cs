using AAA.Web.Web.Utils;
using System.Web.Mvc;

namespace AAA.Web.Controllers
{
    public class HomeController : AAAControllerBase
    {
        public ActionResult Index()
        {
            var fvi = SiteHelper.GetFileVersionInfo();
            ViewBag.UserName = "caizz@vanke.com";
            ViewBag.PlatformName = fvi.ProductName;
            ViewBag.PlatformVersion = fvi.FileVersion;
            ViewBag.PlatformCopyright = fvi.LegalCopyright;
            return View();
        }

        public ActionResult Portal()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}