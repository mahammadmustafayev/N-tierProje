using BusinessLayer.Abstract;
using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Controllers;

public class AuthController : Controller
{
    private readonly UserManager<AppUser> _userManager;
    private readonly RoleManager<AppRole> _roleManager;
    private readonly SignInManager<AppUser> _signInManager;
    private readonly IAuthService _authService;
    private readonly Context _context;

    public AuthController(UserManager<AppUser> userManager,
        RoleManager<AppRole> roleManager,
        SignInManager<AppUser> signInManager,
        Context context,
        IAuthService authService)
    {
        _userManager = userManager;
        _roleManager = roleManager;
        _signInManager = signInManager;
        _context = context;
        _authService = authService;
    }

    [HttpPost]
    public async Task<IActionResult> CreateSeedAsync()
    {
        var administrator = new AppUser
        {
            Id = Guid.NewGuid().ToString(""),
            UserName = "manageAdmin",
            Email = "backtestevo@gmail.com",
            FirstName = "Mahammad",
            LastName = "Mustafayev",
            NormalizedUserName = "MANAGEADMIN",
            NormalizedEmail = "BACKTESTEVO@GMAIL.COM",
            EmailConfirmed = false,
            PhoneNumberConfirmed = false,
            SecurityStamp = Guid.NewGuid().ToString("D")
        };

        await _userManager.CreateAsync(administrator, "PaSSword1!");
        await _userManager.AddToRoleAsync(administrator, "admin");

        await _context.SaveChangesAsync();
        return Ok("Admin Created");
    }
    [HttpPost]
    public async Task<IActionResult> CreateRoles()
    {
        string[] roles = { "admin", "member", };

        foreach (string role in roles)
        {
            if (_roleManager.Roles.All(r => r.Name != role))
            {
                await _roleManager.CreateAsync(new AppRole() { Name = role });
            }
        }
        return Ok("Roles Created");
    }
}
