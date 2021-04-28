using System;
using System.Collections.Generic;
using System.Text;

namespace Taxi.Common.Models
{
    public class TripSummary
    {
        public double Distance { get; set; }

        public TimeSpan Time { get; set; }

        public decimal Value { get; set; }
    }
}
