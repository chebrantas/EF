using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration;

namespace EF2018MVC.Models.EntityTypeConfiguration
{
    public class ReservationConfiguration:EntityTypeConfiguration<Reservation>
    {
        public ReservationConfiguration()
        {
        }
    }
}