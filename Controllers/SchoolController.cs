using Microsoft.AspNetCore.Mvc;

namespace platzi_asp_net_core.Controllers
{
    public class SchoolController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}