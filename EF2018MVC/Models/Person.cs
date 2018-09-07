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
        //FullName duombazeje nera nes nera set atributo, bet atvaizduoti galima, nes sitas property yra atmintyje
        //surenka is 2 laukeliu duomenis ir atvaizduoja
        public string FullName
        {
            get { return String.Format("{0} {1}", LastName.Trim(), FirstName); }
        }
        public byte[] RowVersion { get; set; }


        //sukurti keli bidirection rysiai tap 2 lenteliu
        public List<Lodging> PrimaryContactFor { get; set; }
        public List<Lodging> SecondaryContactFor { get; set; }

        public PersonPhoto Photo { get; set; }

        //vienas is budu lentele itraukti i modeli yra itraukti kaip zemiau i sita lentele kuri tures zinias apie ta kita lentele ir nereiks
        //DBSet naudoti itrauks automatiskai
        //public List<Reservation> Reservations { get; set; }

        public PersonalInfo Info { get; set; }
        public Address Address { get; set; }


    }
}