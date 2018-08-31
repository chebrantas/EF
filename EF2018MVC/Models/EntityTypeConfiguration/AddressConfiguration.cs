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

        }
    }
}