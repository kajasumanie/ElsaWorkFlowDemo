using Microsoft.AspNetCore.Mvc;

namespace ElsaWorkFlowDemo.Controllers
{
    public class ElsaFirstPageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
