
using BusinessLayer.Concrete;
using DataAccessLayer.EntitiyFramework;
using Microsoft.AspNetCore.Mvc;

namespace TravelCoreProje.Controllers
{
    public class DestinationController : Controller
    {
        DestinationManager destinationManager = new DestinationManager(new EfDestinationDal()); 
        public IActionResult Index()
        {
            var values = destinationManager.TGetlist();
            return View(values);
        }
    }
}
