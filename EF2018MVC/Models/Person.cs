using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EF2018MVC.Models
{
    public class Person
    {
        public int SocialSecurityNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public byte[] RowVersion { get; set; }
        

        //sukurti keli bidirection rysiai tap 2 lenteliu
        public List<Lodging> PrimaryContactFor { get; set; }
        public List<Lodging> SecondaryContactFor { get; set; }

        public PersonPhoto Photo { get; set; }

        public PersonalInfo Info { get; set; }
        public Address Address { get; set; }

       
    }
}