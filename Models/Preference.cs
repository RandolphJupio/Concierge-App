﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConciergeApp.Models
{
    public class Preference
    {
        public int Id { get; set; }
        public string TypeofBusiness { get; set; }
        public decimal Price { get; set; }
        public string FoodType { get; set; }
        
    }
}
