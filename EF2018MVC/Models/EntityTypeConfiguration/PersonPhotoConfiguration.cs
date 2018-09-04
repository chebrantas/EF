using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace EF2018MVC.Models.EntityTypeConfiguration
{
    public class PersonPhotoConfiguration:EntityTypeConfiguration<PersonPhoto>
    {
        public PersonPhotoConfiguration()
        {
            HasKey(p => p.PersonId);
            HasRequired(p => p.PhotoOf).WithOptional(p => p.Photo);
        }
    }
}