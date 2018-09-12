using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;


namespace EF2018MVC.Models.EntityTypeConfiguration
{
    public class TripConfiguration : EntityTypeConfiguration<Trip>
    {
        public TripConfiguration()
        {
            //nurodomas PK primary key
            HasKey(t => t.Identifier);
            Property(t => t.Identifier).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(t => t.RowVersion).IsRowVersion();

            //many to many rysys tik pakeiciam pavadinima nes pagal modeli turetu but labiau TripActivities nei kad EF pats
            //nusprende ActivityTrips
            //kadangi konfiguruojame Trip klaseje tai MapLeft puseje buna konfiguruojamos klases ID TripIdentifier
            HasMany(t => t.Activities).WithMany(a => a.Trips)
                .Map(c =>
                {
                    c.ToTable("TripActivities");
                    c.MapLeftKey("TripIdentifier");
                    c.MapRightKey("ActivityId");
                });

        }
    }
}