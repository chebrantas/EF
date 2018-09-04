using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace EF2018MVC.Models
{
    public class Trip
    {
        public Guid Identifier { get; set; }
        [DisplayFormat(DataFormatString = "{0:yyyy.MM.dd}")]
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal CostUSD { get; set; }

        public List<Activity> Activities { get; set; }
        public byte[] RowVersion { get; set; }
    }
}