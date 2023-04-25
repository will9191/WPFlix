using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Flix.Models;

[Table("MovieRating")]
public class MovieRating
{
    [Key, Column(Order = 1)]
     public int MovieId { get; set; }
    [ForeignKey("MovieId")]
    public Movie Movie { get; set; }

    [Key, Column(Order = 2)]
     public int UseriD { get; set; }
    [ForeignKey("UserId")]
    public AppUser User { get; set; }

    [Required]
    public byte RatingValue { get; set }

    [Required]
    public DateTime RatingDate { get; set; }

    
}
}
