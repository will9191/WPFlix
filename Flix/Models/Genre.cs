using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace Flix.Models;

[Table("Genre")]
public class Genre
{
    [Key]
    public int id { get; set; }
    [Display(Name = "Name")]
    [Required(ErrorMessage = "Name is required")]
    [StringLength(30, ErrorMessage = "Name has to have 30 caracters")]
    public string Name { get; set; }
}
