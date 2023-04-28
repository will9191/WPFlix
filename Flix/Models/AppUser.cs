using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Flix.Models;

public class AppUser : IdentityUser
{
    [Required]
    [StringLength(60)]
    public string Name { get; set; }

    [Required]
    [DataType(DataType.Date)]
    public DateTime DateOfBirth { get; set; }
    
    [StringLength(200)]
    public string ProfilePicture { get; set; }
    
    public ICollection<MovieComment> Comments { get; set; }
    public ICollection<MovieRating> Ratings { get; set; }
}

