using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models
{
    public class Review
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string ReviewerName { get; set; } = string.Empty;

        [Required]
        [StringLength(500)]
        public string Comment { get; set; } = string.Empty;

        [Range(1, 10)]
        public int Score { get; set; }

        public int MovieId { get; set; }

        public Movie? Movie { get; set; }
    }
}