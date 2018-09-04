using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration;

namespace EF2018MVC.Models.EntityTypeConfiguration
{
    public class DestinationConfiguration:EntityTypeConfiguration<Destination>
    {
        public DestinationConfiguration()
        {
            Property(d => d.Name).IsRequired();
            Property(d => d.Description).HasMaxLength(500);
            Property(d => d.Photo).HasColumnType("image");


            //jei vienkryptis relationship rysys tai toki nustatome ir foreignkey priskiriam
            //HasMany(d => d.Lodgings).WithRequired().HasForeignKey(l => l.LocationId);
            
            ////relationship 1 to Many
            //HasMany(d => d.Lodgings).WithRequired(l => l.Destination);
        }
    }
}