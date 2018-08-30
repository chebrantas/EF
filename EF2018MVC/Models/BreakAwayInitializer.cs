using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EF2018MVC.Models
{
    public class BreakAwayInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<BreakAwayContext>
    {
        protected override void Seed(BreakAwayContext context)
        {
            context.Destinations.Add(new Destination { Country = "Indonesia", Name = "Bali", Description = "EcoTourism at its best in exquisite Bali" });
            context.Lodgings.Add(new Lodging { Name = "Ilgas kelias namo per kopas", Destination = new Destination { Country = "Lithuania", Name = "Kaunas", Description = "Krepsinio sostine" } });
            base.Seed(context);
        }
    }
}