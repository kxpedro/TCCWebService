using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebService.Consuming.GoogleMaps;
using WebService.Consuming.GoogleMaps.Requests;
using WebService.Entities.Consumer;
using WebService.Entities.Consumer.GoogleMaps;

namespace WebService.Consuming
{
    public class DirectionsConsumer
    {
        /// <summary>
        /// Busca melhores rotas de acordo com as preferencias do usuario
        /// </summary>
        /// <param name="origin">Ponto de origem da rota</param>
        /// <param name="destination">Ponto de destino da rota</param>
        /// <param name="arrivalTime">Tempo de chegada</param>
        /// <param name="departureTime">Hora de saida</param>
        /// <returns></returns>
        public async Task<List<Options>> GetBestRoutesByDirection(string origin, string destination, TimeSpan departureTime, string arrivalTime = "", string travelMode = "")
        {
            DirectionsRequest directionsRequest = new DirectionsRequest();

            List<Options> lsOptions = new List<Options>();

            var p = Commun.GetParametersValues(origin, destination, departureTime, arrivalTime, travelMode);
            Directions directions = await directionsRequest.GetDirectionsByOriginAndDestination(p);

            if (directions != null && (directions.status != "NOT_FOUND" || directions.status != "ZERO_RESULTS"))
            {
                foreach (var r in directions.routes)
                {                  
                    Options option = new Options();

                    if(r.fare != null)
                        option.CostValue = r.fare.value;

                    foreach (var l in r.legs)
                    {
                        option.DistanceValue = l.distance.value;
                        option.DurationValue = l.duration.value;

                        if(l.duration_in_traffic != null)
                            option.TrafficDurationValue = l.duration_in_traffic.value;

                        option.Description = travelMode;

                        lsOptions.Add(option);
                    }
                }
            }

            return lsOptions;
        }
    }
}
