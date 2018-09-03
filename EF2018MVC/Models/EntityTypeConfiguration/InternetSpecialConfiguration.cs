using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration;

namespace EF2018MVC.Models.EntityTypeConfiguration
{
    public class InternetSpecialConfiguration:EntityTypeConfiguration<InternetSpecial>
    {
        public InternetSpecialConfiguration()
        {
            //aprasomas relationship 1 to many ir aprasomas Foreign Key (FK)
            HasRequired(s => s.Accommodation).WithMany(l => l.InternetSpecials).HasForeignKey(s => s.AccommodationId);
        }
    }
}