using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Areas.Manage.Controllers;

[Area("Manage")]
public class ServiceController : Controller
{
    private readonly Context _context;
    private readonly IWebHostEnvironment _env;

    public ServiceController(Context context, IWebHostEnvironment env)
    {
        _context = context;
        _env = env;
    }
    public IActionResult Index()
    {
        List<Service> services = _context.Services.ToList();
        return View(services);
    }
    public IActionResult Create()
    {
        return View();
    }
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(Service service)
    {
        //if (service.ImageUrl != null)
        //{

        //    if (service.ImageUrl.Length > 2097152)
        //    {
        //        ModelState.AddModelError("ImageFile", "Image size must be lower than 2mb");
        //        return View();
        //    }

        //    string fileName = service.ImageUrl;
        //    if (fileName.Length > 64)
        //    {
        //        fileName = fileName.Substring(fileName.Length - 64, 64);
        //    }
        //    string newFileName = Guid.NewGuid().ToString() + fileName;

        //    string path = Path.Combine(_env.WebRootPath, "assets/upload", newFileName);

        //    using (FileStream stream = new FileStream(path, FileMode.Create))
        //    {
        //        film.ImageFile.CopyTo(stream);
        //    }
        //    film.Image = newFileName;
        //}
        _context.Services.Add(service);
        _context.SaveChanges();

        return RedirectToAction("Index");
    }
    public IActionResult Edit()
    {
        return View();
    }
}
