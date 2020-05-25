using System;
using System.Collections.Generic;
using System.Text;

namespace WebService.Consuming.GoogleMaps
{
    public static class Commun
    {
        public static Parameters GetParametersValues(string origin, string destination, string arrivalTime, string departureTime)
        {
            Parameters p = new Parameters()
            {
                Origin = origin,
                Destination = destination,
                Key = "AIzaSyD_Kt18RInV_hT53KM7s9NdLPaXBiMmbSc",
                ArrivalTime = arrivalTime,
                DepartureTime = departureTime
            };

            return p;
        }
    }
}
