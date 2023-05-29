using System.ComponentModel.DataAnnotations;

namespace Flix.DataTransferObjects
{
    public class RegisterDto
    {
        [Display(Name = "Full Name")]
        [Required(ErrorMessage = "Please, enter your Name")]
        [StringLength(60, ErrorMessage = "The name must have a maximum of 60 characters ")]
        public string Name { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Date of Birth")]
        [Required(ErrorMessage = "Plase, enter your Date of Birth")]
        public DateTime DataOfBirth { get; set; }
        
        [Required(ErrorMessage = "Please, your Email")]
        [EmailAddress(ErrorMessage = "Please, enter your valid Email")]
        [StringLength(100, ErrorMessage = "The Email must have a maximum of 60 characters ")]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        [Required(ErrorMessage = "Please, enter your Password")]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "The password must have a minimum of 6 characters and a maximum of 20 characters. ")]
        public string Password { get; set; }
        
        [DataType(DataType.Password)]
        [Display(Name = " Confirm Password")]
        [Compare( "Password", ErrorMessage = "Passwords are not the same")]
        
        public string ConfirmPassword { get; set; }
    }

}