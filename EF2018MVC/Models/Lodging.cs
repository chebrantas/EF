﻿using System.Collections.Generic;
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
        public decimal MilesFromNearestAirport { get; set; }

        //testavimui sukurtas buvo
        //public int LocationId { get; set; }

        //reference property sitas vadinasi
        public Destination Destination { get; set; }
        public int DestinationId { get; set; }

        public List<InternetSpecial> InternetSpecials { get; set; }

        public Person PrimaryContact { get; set; }
        public Person SecondaryContact { get; set; }
    }
}