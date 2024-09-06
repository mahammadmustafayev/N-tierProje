using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramewrok;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.About;

public class AboutList : ViewComponent
{
    AboutManager aboutManager = new AboutManager(new EfAbout());
    public IViewComponentResult Invoke()
    {
        var values = aboutManager.GetList();
        return View(values);
    }
}
