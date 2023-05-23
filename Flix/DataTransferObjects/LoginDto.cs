using System.ComponentModel.DataAnnotations;

namespace Flix.DataTransferObjects;

public class LoginDto
{
    [Display(Name = "Email or username")]
    [Required(ErrorMessage = "Email or username is required")]
    public string Email { get; set; }
    [Display(Name = "Password")]
    [Required(ErrorMessage = "Please, enter your password")]
    [DataType(DataType.Password)]
    public string Password { get; set; }
    [Display(Name = "Keep connected?")]
    public bool RememberMe { get; set; }
    
    public string ReturnUrl { get; set; }
}
