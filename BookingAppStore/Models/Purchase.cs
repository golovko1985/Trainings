﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BookingAppStore.Models
{
    public class Purchase
    {
        [Key]
        public int PurchaceId { get; set; }
        public string Person { get; set; }
        public string Address { get; set; }
        public int BookId { get; set; }
        public DateTime Date { get; set; }
    }
}