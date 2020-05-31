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
        public async Task<List<BestRoutes>> GetBestRoutes(string origin, string destination, MotoristaPreferencias motoristaPreferencias)
        {   
            DirectionsConsumer directionsConsumer = new DirectionsConsumer();

            List<BestRoutes> lsBestRoutes = await directionsConsumer.GetBestRoutesByDirection(origin, destination, motoristaPreferencias.ArrivalTime, motoristaPreferencias.DepartureTime);


            return lsBestRoutes;
        }
    }
}
