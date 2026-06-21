using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcMovie.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Tytuł jest wymagany")]
        [StringLength(100)]
        public string Title { get; set; } = string.Empty;

        [Required(ErrorMessage = "Reżyser jest wymagany")]
        [StringLength(100)]
        public string Director { get; set; } = string.Empty;

        [Range(1, 10, ErrorMessage = "Ocena musi być od 1 do 10")]
        public int Rating { get; set; }

        public ICollection<Review>? Reviews { get; set; }
    }
}