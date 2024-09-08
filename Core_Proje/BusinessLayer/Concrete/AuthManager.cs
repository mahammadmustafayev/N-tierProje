using BusinessLayer.Abstract;
using BusinessLayer.AuthSM;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;

namespace BusinessLayer.Concrete;

public class AuthManager : IAuthService
{
    private readonly UserManager<AppUser> _userManager;
    private readonly SignInManager<AppUser> _signInManager;

    public AuthManager(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
    {
        _userManager = userManager;
        _signInManager = signInManager;
    }

    public async Task<AppUser> LoginAsync(LoginSM loginSM)
    {

        var result = await _signInManager.PasswordSignInAsync(loginSM.Email, loginSM.Password, loginSM.RememberMe, false);
        if (result.Succeeded)
        {
            return await _userManager.FindByEmailAsync(loginSM.Email);
        }
        return null;
    }

    public async Task<IdentityResult> RegisterAsync(RegisterSM registerSM)
    {
        AppUser newUser = new()
        {
            UserName = registerSM.FirstName,
            Email = registerSM.Email
        };
        return await _userManager.CreateAsync(newUser, registerSM.Password);
    }
}
