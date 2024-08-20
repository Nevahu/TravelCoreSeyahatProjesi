
using BusinessLayer.Concrete;
using DataAccessLayer.EntitiyFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelCoreProje.ViewComponents.Default
{
    public class _Feature : ViewComponent
    {
        FeatureManager FeatureManager = new FeatureManager(new EfFeatureDal());
        public IViewComponentResult Invoke()
        {

            var values = FeatureManager.TGetlist();
            return View();
        }
    }
}
