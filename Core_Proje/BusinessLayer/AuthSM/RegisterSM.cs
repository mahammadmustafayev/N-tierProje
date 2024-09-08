using System.ComponentModel.DataAnnotations;

namespace BusinessLayer.AuthSM;

public class RegisterSM
{
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    [EmailAddress]
    public string Email { get; set; } = null!;
    [DataType(DataType.Password)]
    public string Password { get; set; } = null!;
    [DataType(DataType.Password), Compare(nameof(Password))]
    public string ConfirmPassword { get; set; } = null!;

}
