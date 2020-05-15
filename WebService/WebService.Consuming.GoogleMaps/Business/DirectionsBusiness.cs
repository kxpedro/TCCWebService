using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using WebService.Consuming.GoogleMaps.Routes.Directions;

namespace WebService.Consuming.GoogleMaps.Business
{
    public class DirectionsBusiness
    {
        public struct Parameters
        {
            public string Origin { get; set; }
            public string Destination { get; set; }
            public string Key { get; set; }
            public string ArrivalTime { get; set; }
            public string DepartureTime { get; set; }
        }

        public async Task<IEnumerable<Directions>> GetDirectionsByOriginAndDestination(string origin, string destination)
        {
            List<Directions> lsDirections = new List<Directions>();
            HttpClient httpClient = new HttpClient();

            Parameters p = new Parameters()
            {
                Origin = origin,
                Destination = destination,
                Key = "AIzaSyD_Kt18RInV_hT53KM7s9NdLPaXBiMmbSc",
                ArrivalTime = "",
                DepartureTime = ""
            };            

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
