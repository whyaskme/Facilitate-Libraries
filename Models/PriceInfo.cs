﻿using Facilitate.Libraries.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facilitate.Libraries.Models
{
    public class PriceInfo
    {
        public PriceInfo()
        {
            priceType = string.Empty;
            total = 0.00;
            pricePerSquare = 0.00;
            monthly = 0.00;
            apr = 0.00;
            months = 0;
        }

        public string priceType { get; set; }
        public double total { get; set; }
        public double pricePerSquare { get; set; }
        public double monthly { get; set; }
        public double apr { get; set; }
        public int months { get; set; }
    }
}
