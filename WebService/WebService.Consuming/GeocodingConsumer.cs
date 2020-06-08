using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebService.Consuming.GoogleMaps;
using WebService.Consuming.GoogleMaps.Requests;
using WebService.Entities.Consumer.GoogleMaps;

namespace WebService.Consuming
{
    public class GeocodingConsumer
    {
        public async Task<AddressComponents> GetAddressComponents(string endereco, TimeSpan horarioSaido)
        {
            GeocodingRequest geocodingRequest = new GeocodingRequest();

            Parameters p = new Parameters()
            {                
                Destination = endereco,
                Key = "AIzaSyD_Kt18RInV_hT53KM7s9NdLPaXBiMmbSc",                
                DepartureTime = horarioSaido,
            };

            Geocoding geocoding = await geocodingRequest.GetGeocoding(p);            

            AddressComponents addressComponents = new AddressComponents();
            addressComponents.Endereco = geocoding.results[0].formatted_address;
            addressComponents.Latitude = geocoding.results[0].geometry.location.lat;
            addressComponents.Longitude = geocoding.results[0].geometry.location.lng;

            return addressComponents;
        }
    }
}
