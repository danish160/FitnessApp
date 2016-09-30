using System.Web.Mvc;

namespace FitnessApp.Web.Controllers
{
    public class AboutController : FitnessAppControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}