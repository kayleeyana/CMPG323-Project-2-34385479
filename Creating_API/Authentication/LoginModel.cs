using System.ComponentModel.DataAnnotations;
namespace Creating_API.Authentication
{
    public class LoginModel
    {
            [Required(ErrorMessage = "User Name is required")]
            public string? Username { get; set; }

            [Required(ErrorMessage = "Password is required")]
            public string? Password { get; set; }
        

    }
}
