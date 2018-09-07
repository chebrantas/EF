using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration;

namespace EF2018MVC.Models.EntityTypeConfiguration
{
    public class LodgingConfiguration : EntityTypeConfiguration<Lodging>
    {
        public LodgingConfiguration()
        {
            Property(l => l.Name).IsRequired().HasMaxLength(200);
            Property(l => l.MilesFromNearestAirport).HasPrecision(8, 2);

            HasRequired(l => l.Destination).WithMany(d => d.Lodgings);//.WillCascadeOnDelete(false);  neistrina tada susijusiu lauku automatiskai, reikia paciam aprasyti
            HasOptional(l => l.PrimaryContact).WithMany(p => p.PrimaryContactFor);
            HasOptional(l => l.SecondaryContact).WithMany(p => p.SecondaryContactFor);

            
            //nustatymai kad pakeisti Discriminator propercio pavadinima, ir reiksmes naudojima jame
            Map(m =>
            {
                m.ToTable("Lodgings");
                m.Requires("LodgingType").HasValue("Standard");
            })
            .Map<Resort>(m =>
            {
                m.Requires("LodgingType").HasValue("Resort");
            });
        }
    }
}