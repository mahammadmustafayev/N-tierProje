using BusinessLayer.AuthSM;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;

namespace BusinessLayer.Abstract;

public interface IAuthService
{
    Task<IdentityResult> RegisterAsync(RegisterSM registerSM);
    Task<AppUser> LoginAsync(LoginSM loginSM);
}
