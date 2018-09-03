using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using EF2018MVC.Models.EntityTypeConfiguration;

namespace EF2018MVC.Models
{
    public class BreakAwayContext:DbContext
    {
        public DbSet<Destination> Destinations { get; set; }
        public DbSet<Lodging> Lodgings { get; set; }
        public DbSet<Trip> Trips { get; set; }
        public DbSet<Person> Persons { get; set; }


        //naudojam kad visus nustatymus duomenu bazei atliktu pagal nurodymus ko nepadare automatiskai . visi nustatymai sudeti i 
        //Models/EntityTypeConfiguration o is ten uzloadinami OnModelCreating metodu
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new DestinationConfiguration());
            modelBuilder.Configurations.Add(new LodgingConfiguration());
            modelBuilder.Configurations.Add(new TripConfiguration());
            modelBuilder.Configurations.Add(new PersonConfiguration());
            modelBuilder.Configurations.Add(new AddressConfiguration());
            modelBuilder.Configurations.Add(new InternetSpecialConfiguration());



            //complex type visada rasomi paskutiniai
            modelBuilder.ComplexType<Address>();
            modelBuilder.ComplexType<PersonalInfo>();


            base.OnModelCreating(modelBuilder);
        }
    }
}