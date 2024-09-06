using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramewrok;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Feature;

public class FeatureList : ViewComponent
{
    FeatureManager featureManager = new FeatureManager(new EfFeature());
    public IViewComponentResult Invoke()
    {
        var values = featureManager.GetList();
        return View(values);
    }
}
