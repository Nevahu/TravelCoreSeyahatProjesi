using BusinessLayer.Concrete;
using DataAccessLayer.EntitiyFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelCoreProje.ViewComponents.Default
{
    public class _SubAbout : ViewComponent
    {
        SubAboutManager subAboutManager = new SubAboutManager(new EfSubAboutDal());
        public IViewComponentResult Invoke()
        {
            var values = subAboutManager.TGetlist();
            return View(values);
        }
    }
}
