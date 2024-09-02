using Microsoft.AspNetCore.Mvc;

namespace TravelCoreProje.ViewComponents.Default
{
    public class _Testimonial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
