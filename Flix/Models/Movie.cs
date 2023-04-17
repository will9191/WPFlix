using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace Flix.Models
{
    [Table("Movie")]
    public class Movie
    {
        [Key]
        public int id { get; set; }
        [Display(Name = "Original Title")]
        [Required(ErrorMessage = "Original Title is required")]
        [StringLength(100, ErrorMessage = "Original Title has to have 100 caracters")]
        public string OriginalTitle { get; set; }

        [Display(Name = "Title")]
        [Required(ErrorMessage = "The Title is required")]
        [StringLength(100, ErrorMessage = "Title has to have 100 caracters")]
        public string Title { get; set; }

        [Display(Name = "Synopsis")]
        [StringLength(5000, ErrorMessage = "The Synopsis has to have 5000 caracters")]
        public string Synopsis { get; set; }

        public string MovieYear { get; set; }

        public string Duration { get; set; }

        public string AgeRating { get; set; }

        public string Image { get; set; }
    }
}