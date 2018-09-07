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
            Property(p => p.Photo).HasColumnType("image");

            //table name keiciamas
            //ToTable("PersonPhotos");

            //cia jei norime sujunkti 2 clases i viena datatable tai mapinam prie bendro pavadinimo
            //o sitos klases turi tureti tarpusavyje rysi 1 to 1, o ne 1 to optional
            //HasRequired(p => p.PhotoOf).WithRequiredDependent(p => p.Photo);
            //ToTable("People");

        }
    }
}