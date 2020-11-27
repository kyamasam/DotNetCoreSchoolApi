using Microsoft.AspNetCore.Mvc;

namespace Roster.Controllers
{
    public class DefaultController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}