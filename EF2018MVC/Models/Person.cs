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
    }
}