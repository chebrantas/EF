﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EF2018MVC.Models
{
    public class Reservation
    {
        public int ReservationId { get; set; }
        public DateTime DateTimeMade { get; set; }
        public Person Traveler { get; set; }
        public Trip Trip { get; set; }
        public DateTime PaidInFull { get; set; }
    }
}