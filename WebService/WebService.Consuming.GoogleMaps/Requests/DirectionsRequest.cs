using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using WebService.Entities.Consumer.GoogleMaps;

namespace WebService.Consuming.GoogleMaps.Requests
{
    public class DirectionsRequest
    {   
        public async Task<Directions> GetDirectionsByOriginAndDestination(Parameters p)
        {
            Directions lsDirections = new Directions();
            HttpClient httpClient = new HttpClient();

            string requestUri = $"https://maps.googleapis.com/maps/api/directions/json?origin={p.Origin}&destination={p.Destination}&key={p.Key}";
            httpClient.BaseAddress = new Uri(requestUri);
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = await httpClient.GetAsync(requestUri);

            if (response.IsSuccessStatusCode)
            {
                var json = response.Content.ReadAsStringAsync().Result;
                lsDirections = JsonConvert.DeserializeObject<Directions>(json);
            }

            return lsDirections;
        }
    }
}
