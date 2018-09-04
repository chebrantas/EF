using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EF2018MVC.Models
{
    public class Activity
    {
        public int ActivityId { get; set; }
        public string  Name { get; set; }

        public List<Trip> Trips { get; set; }
    }
}