using System.ComponentModel.DataAnnotations;

namespace BowlersAPI.Models
{
    public class Team
    {
        [Key]
        [Required]
        public int TeamId { get; set; }
        [Required]
        public string TeamName { get; set; }
    }
}