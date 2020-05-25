using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using WebService.Consuming.GoogleMaps.Classes;
using WebService.Consuming.GoogleMaps.Routes.Directions;

namespace WebService.Consuming.GoogleMaps.Business
{
    public class DirectionsBusiness
    {
        public async Task<BestRoutes> GetBestRoutesByDirection(string origin, string destination, string arrivalTime, string departureTime)
        {
            BestRoutes bestRoutes = new BestRoutes();

            var p = Commun.GetParametersValues(origin, destination, arrivalTime, departureTime);
            
            var directions = await GetDirectionsByOriginAndDestination(p);


            return bestRoutes;
        }


        public async Task<IEnumerable<Directions>> GetDirectionsByOriginAndDestination(Parameters p)
        {
            List<Directions> lsDirections = new List<Directions>();
            HttpClient httpClient = new HttpClient();            

            string requestUri = $"http://maps.googleapis.com/maps/api/directions/json?origin={p.Origin}&destination={p.Destination}&key={p.Key}";
            httpClient.BaseAddress = new Uri(requestUri);
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));                        

            HttpResponseMessage response = await httpClient.GetAsync(requestUri);

            if (response.IsSuccessStatusCode)
            {
                var json = response.Content.ReadAsStringAsync().Result;
                lsDirections = JsonConvert.DeserializeObject<List<Directions>>(json);
            }

            return lsDirections;
        }
    }
}
