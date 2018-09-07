using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


//klase isvesta is Lodging, kai naudojama ji vistiek rasoma i Lodging lentele
//bet Discriminator tada rodo kad yrasas is Resort klases
//o kitos kalses rodo is Lodging
namespace EF2018MVC.Models
{
    public class Resort:Lodging
    {
        public string Entertainment { get; set; }
        public string Activities { get; set; }
    }
}