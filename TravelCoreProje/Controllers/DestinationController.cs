using Microsoft.AspNetCore.Mvc;

namespace TravelCoreProje.Controllers
{
    public class DestinationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
