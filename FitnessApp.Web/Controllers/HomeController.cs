using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace FitnessApp.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : FitnessAppControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}