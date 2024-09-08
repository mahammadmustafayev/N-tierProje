using System.ComponentModel.DataAnnotations;

namespace BusinessLayer.AuthSM;

public class LoginSM
{
    public string Email { get; set; } = null!;
    [DataType(DataType.Password)]
    public string Password { get; set; } = null!;
    public bool RememberMe { get; set; }
}
