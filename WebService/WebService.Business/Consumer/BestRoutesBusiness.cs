using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebService.Consuming;
using WebService.Entities;
using WebService.Entities.Consumer;
using WebService.Entities.Enum;

namespace WebService.Business.Consumer
{
    public class BestRoutesBusiness
    {
        public async Task<List<Options>> GetBestRoutes(string origin, string destination, MotoristaPreferencias motoristaPreferencias)
        {   
            DirectionsConsumer directionsConsumer = new DirectionsConsumer();
            List<Options> lsBestRoutes = await directionsConsumer.GetBestRoutesByDirection(origin, destination, motoristaPreferencias.DepartureTime, motoristaPreferencias.ArrivalTime);

            return lsBestRoutes;
        }

        public async Task<List<Options>> GetBestRoutes(string origin, string destination, TimeSpan departureTime, string arrivalTime = "", string travelMode = "")
        {
            DirectionsConsumer directionsConsumer = new DirectionsConsumer();
            List<Options> lsOptions = await directionsConsumer.GetBestRoutesByDirection(origin, destination, departureTime, arrivalTime, travelMode);

            return lsOptions;
        }

        public eTransportOptions CompareCostsOfAllTransportOptions(double transportAppCost, double transitCost, double publicTransportCost, double cabCost)
        {
            return eTransportOptions.Driver;
        }

        public eTransportOptions CompareTimeOfAllTransportOptions(int transportAppDuration, int transitDuration, int publicTransportDuration, int cabDuration)
        {
            return eTransportOptions.Driver;
        }

        public eTransportOptions CompareDistanceOfAllTransportOptions(int transportAppDistance, int transitDistance, int publicTransportDistance, int cabDistance)
        {
            return eTransportOptions.Driver;
        }


    }
}
