using System.Web.Mvc;

namespace MyAbpDemo.Web.Controllers
{
    public class HomeController : MyAbpDemoControllerBase
    {
        public ActionResult Index()
        { 
            return View("~/App/Main/views/layout/layout.cshtml"); //Layout of the angular application.
        }
	}
}