using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Areas.Manage.Controllers;

[Area("Manage")]
public class DashboardController : Controller
{

    public IActionResult Index()
    {
        return View();
    }
}
