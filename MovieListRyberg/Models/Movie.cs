using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieListRyberg.Models
{
    public class Movie
    {
        public int MovieId { get; set; }
        
        [Required(ErrorMessage = "Please enter value")]
        public string Name { get; set; }

        [Required (ErrorMessage = "Please enter a year")]
        public int? Year { get; set; }

        [Required(ErrorMessage = "Please enter a rating")]
        public int? Rating { get; set; }

        [Required(ErrorMessage ="Please enter a genre")]
        public string GenreId { get; set; }
        public Genre Genre { get; set; }
    }
}
