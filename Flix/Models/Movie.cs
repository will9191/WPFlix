using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace Flix.Models
{
    [Table("Movie")]
    public class Movie
    {
        [Key]
        public int id { get; set; }


        [Display(Name = "Title")]
        [Required(ErrorMessage = "The Title is required")]
        [StringLength(100, ErrorMessage = "Title has to have 100 caracters")]
        public string Title { get; set; }

        [Display(Name = "Original Title")]
        [Required(ErrorMessage = "Original Title is required")]
        [StringLength(100, ErrorMessage = "Original Title has to have 100 caracters")]
        public string OriginalTitle { get; set; }

        [Display(Name = "Synopsis")]
        [Required(ErrorMessage = "The Synopsis is required")]
        [StringLength(8000, ErrorMessage = "The Synopsis has to have 5000 caracters")]
        public string Synopsis { get; set; }

        [Column(TypeName = "Year")]
        [Display(Name = "Rookie Year ")]
        [Required(ErrorMessage = "The Rookie Year is required")]
        public Int16 MovieYear { get; set; }

        [Display(Name = "Length0 (in minute)")]

        public Int16 Duration { get; set; }

        [Display(Name = "Age rating")]
        [Required(ErrorMessage = "The Age rating is required")]

        public byte AgeRating { get; set; }

        [StringLength(200)]
        [Display(Name = "Photo")]

        public string Image { get; set; }

        [NotMapped]
        [Display(Name = "Durating")]

        public string HourDuration {get {
            return TimeSpan.FromMinutes(Duration).ToString(@"%h 'Hour' 'mm' 'Minutes' ");
        }}
        
        public ICollection<MovieComment> Comments { get; set; }
        public ICollection<MovieGenre> Genres { get; set; }
        public ICollection<MovieRating> Ratings { get; set; }
    }
}