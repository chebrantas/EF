using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF2018MVC.Models.EntityTypeConfiguration
{
    public class PersonConfiguration:EntityTypeConfiguration<Person>
    {
        public PersonConfiguration()
        {
            HasKey(p => p.SocialSecurityNumber);
            Property(p => p.SocialSecurityNumber).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);
            Property(p => p.RowVersion).IsRowVersion();
        }
    }
}