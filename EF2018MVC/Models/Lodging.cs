using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF2018MVC.Models
{
    public class Lodging
    {
        public int LodgingId { get; set; }
        [Required]
        [MaxLength(200)]
        [MinLength(10)]
        public string Name { get; set; }
        public string Owner { get; set; }
        public bool IsResort { get; set; }
        public Destination Destination { get; set; }
    }
}