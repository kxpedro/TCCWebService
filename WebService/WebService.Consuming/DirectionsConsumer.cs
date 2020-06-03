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
        public async Task<List<Options>> GetBestRoutesByDirection(string origin, string destination, string arrivalTime, string departureTime)
        {
            DirectionsRequest directionsRequest = new DirectionsRequest();

            List<Options> lsbestRoutes = new List<Options>();

            var p = Commun.GetParametersValues(origin, destination, arrivalTime, departureTime);
            Directions directions = await directionsRequest.GetDirectionsByOriginAndDestination(p);

            if (directions.status != "NOT_FOUND" || directions.status != "ZERO_RESULTS")
            {
                foreach (var r in directions.routes)
                {
                    foreach (var l in r.legs)
                    {
                        //var distanceText = l.distance.text;
                        //var durationText = l.duration.text;

                        Options bestRoutes = new Options();
                        bestRoutes.DistanceRoutesValue = l.distance.value;
                        bestRoutes.DurationRoutesValue = l.duration.value;

                        lsbestRoutes.Add(bestRoutes);

                    }
                }
            }

            return lsbestRoutes;
        }
    }
}
