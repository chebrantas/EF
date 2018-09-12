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
        //sitas naudojamas kad nemestu klaidos kur jau inicializuojama be duombazes stringo
        public BreakAwayContext()
        {

        }
        //sitas variantas naudojamas, kai nurodoma koki connectionstringa naudoti 
        //public BreakAwayContext():base("name=DuombazesConnectionString")
        //{

        //}

        //sitas naudojamas jei norime sukurti is kart ir duombazes vardas suteikiamas
        //public BreakAwayContext(string databaseName) : base("Duombaze")
        //{

        //}
        public DbSet<Destination> Destinations { get; set; }
        public DbSet<Lodging> Lodgings { get; set; }
        public DbSet<Trip> Trips { get; set; }
        public DbSet<Person> Persons { get; set; }


        public DbSet<Resort> Resort { get; set; }


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
            modelBuilder.Configurations.Add(new ActivityConfiguration());
            modelBuilder.Configurations.Add(new PersonPhotoConfiguration());

            //toks aprasas klase itraukia i duomenu base kaip lentele taip pat nereikia jokiu papildomu nustatymu
            modelBuilder.Configurations.Add(new ReservationConfiguration());



            //jei turime klase ir nenorime kad ji butu modelio dalis, o tik naudaojama atmintyje
            //ne kaip lentele duombazeje naudojame sekancia eilute
            //modelBuilder.Ignore<Reservation>();





            //complex type visada rasomi paskutiniai
            modelBuilder.ComplexType<Address>();
            modelBuilder.ComplexType<PersonalInfo>();


            base.OnModelCreating(modelBuilder);
        }
    }
}