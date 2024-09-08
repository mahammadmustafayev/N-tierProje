using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramewrok;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.ViewComponents.Service;

public class ServiceList : ViewComponent
{
    ServiceManager manager = new ServiceManager(new EfService());
    public IViewComponentResult Invoke()
    {
        var result = manager.GetList();
        return View(result);
    }
}
