using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebService.Consuming;
using WebService.Entities;
using WebService.Entities.Consumer;

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
            List<Options> lsOptions = await directionsConsumer.GetBestRoutesByDirection(origin, destination, departureTime, string.Empty, travelMode);

            return lsOptions;
        }



        
    }
}
