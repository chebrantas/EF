using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF2018MVC.Models
{
    //[Table("Locations",Schema ="baga")]
    public class Destination
    {
        public int DestinationId { get; set; }
        //[Required]
        public string Name { get; set; }
        //[Required]
        public string Country { get; set; }
        //[MaxLength(500)]
        public string Description { get; set; }
        //[Column(TypeName="image")]
        public byte[] Photo { get; set; }
        public List<Lodging> Lodgings { get; set; }
    }
}

