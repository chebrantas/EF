using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;


namespace EF2018MVC.Models.EntityTypeConfiguration
{
    public class TripConfiguration:EntityTypeConfiguration<Trip>
    {
        public TripConfiguration()
        {
            //nurodomas PK primary key
            HasKey(t => t.Identifier);
            Property(t => t.Identifier).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(t => t.RowVersion).IsRowVersion();

        }
    }
}