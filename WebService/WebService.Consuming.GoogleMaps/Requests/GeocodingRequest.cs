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
    public class GeocodingRequest
    {
        public async Task<Geocoding> GetGeocoding(Parameters p)
        {
            Geocoding geocoding = new Geocoding();
            HttpClient httpClient = new HttpClient();            
            
            string requestUri = $"https://maps.googleapis.com/maps/api/geocode/json?address={p.Destination}&key={p.Key}";
            httpClient.BaseAddress = new Uri(requestUri);
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            HttpResponseMessage response = await httpClient.GetAsync(requestUri);

            if (response.IsSuccessStatusCode)
            {
                var json = response.Content.ReadAsStringAsync().Result;
                geocoding = JsonConvert.DeserializeObject<Geocoding>(json);
            }

            return geocoding;
        }
    }
}
