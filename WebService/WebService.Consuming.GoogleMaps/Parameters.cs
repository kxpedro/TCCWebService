using System;
using System.Collections.Generic;
using System.Text;

namespace WebService.Consuming.GoogleMaps
{
    public class Parameters
    {
        public string Origin { get; set; }
        public string Destination { get; set; }
        public string Key { get; set; }
        public string ArrivalTime { get; set; }
        public string DepartureTime { get; set; }
    }
}
