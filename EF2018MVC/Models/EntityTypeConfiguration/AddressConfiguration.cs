using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;


namespace EF2018MVC.Models.EntityTypeConfiguration
{

    //kai aprasomas complex type inheritinam klase ne is EntityTypeConfiguration, o is ComplexTypeConfiguration
    public class AddressConfiguration:ComplexTypeConfiguration<Address>
    {
        public AddressConfiguration()
        {
          Property(a => a.StreetAddress).HasMaxLength(150);

            //complex type sukonfiguruojame property name kad naudojami kitoje klaseje gautu normalius pavadinimus,
            //o ne pvz Address_StreetAddress o butu StreetAddress
            Property(a => a.AddressId).HasColumnName("AddressId");
            Property(a => a.StreetAddress).HasColumnName("StreetAddress");
            Property(a => a.City).HasColumnName("City");
            Property(a => a.State).HasColumnName("State");
            Property(a => a.ZipCode).HasColumnName("ZipCode");


        }
    }
}