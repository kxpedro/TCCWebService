using System;
using System.Collections.Generic;
using System.Text;

namespace WebService.Entities.Models
{
    public class TravelOptions
    {
        public Address OriginAddress { get; set; }
        public Address DestinationAddress { get; set; }
        public string UserPreference { get; set; }
        public RouteOptions Options { get; set; }
        public string Status { get; set; }
    }

    public class RouteOptions
    {
        public string TravelMode { get; set; }
        public string Distance { get; set; }
        public string Duration { get; set; }
        public string Cousts { get; set; }        
    }

    public class Address
    {
        public string StreetName { get; set; }
        public string StreetNumber { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Neighborhood { get; set; }
    }
}
