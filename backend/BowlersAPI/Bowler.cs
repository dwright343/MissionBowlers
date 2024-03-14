using BowlersAPI.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;
using System.Reflection;

namespace BowlersAPI
{
    public class Bowler
    {
        [Key]
        [Required]
        public int BowlerId { get; set; }
        public string? BowlerFirstName { get; set; }
        public char? BowlerMiddleInit { get; set; }
        public string? BowlerLastName { get; set; }
        [ForeignKey("TeamId")]
        public int? TeamId { get; set; }
        public string? BowlerAddress { get; set; }
        public string? BowlerCity { get; set; }
        public string? BowlerState { get; set; }
        public int? BowlerZip {  get; set; }
        public string? BowlerPhoneNumber { get; set; }
    }
}
