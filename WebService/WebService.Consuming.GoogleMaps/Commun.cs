using System;
using System.Collections.Generic;
using System.Text;
using WebService.Entities.Consumer.GoogleMaps;

namespace WebService.Consuming.GoogleMaps
{
    public static class Commun
    {
        public static Parameters GetParametersValues(string origin, string destination, TimeSpan departureTime, string arrivalTime = "", string travelMode = "")
        {
            Parameters p = new Parameters()
            {
                Origin = origin,
                Destination = destination,
                Key = "AIzaSyD_Kt18RInV_hT53KM7s9NdLPaXBiMmbSc",
                ArrivalTime = arrivalTime,
                DepartureTime = departureTime,
                TravelMode = travelMode
            };

            return p;
        }
    }
}
