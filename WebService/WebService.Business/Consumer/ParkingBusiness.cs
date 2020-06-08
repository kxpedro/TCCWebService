using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebService.Consuming;
using WebService.Entities;
using WebService.Entities.Consumer.GoogleMaps;

namespace WebService.Business.Consumer
{
    public class ParkingBusiness
    {
        public async Task<double> GetBestCostFromAllParkings(List<Estacionamento> estacionamentos, string enderecoDestino, TimeSpan horarioSaida, double raio)
        {
            GeocodingConsumer geocodingConsumer = new GeocodingConsumer();

            List<AddressComponents> lsAddressComponents = new List<AddressComponents>();

            foreach (var e in estacionamentos)
            {
                string enderecoEstacionamento = $"{e.Endereco.Rua},{e.Endereco.Numero} - {e.Endereco.Bairro} - {e.Endereco.Cidade} - {e.Endereco.Estado}";

                var componentesEstacionamento = await geocodingConsumer.GetAddressComponents(enderecoEstacionamento, horarioSaida);               


                lsAddressComponents.Add(componentesEstacionamento);
            }

            var componentesDestino = await geocodingConsumer.GetAddressComponents(enderecoDestino, horarioSaida);
            var latitudeDestinoMin = componentesDestino.Latitude;
            var latitudeDestinoMax = componentesDestino.Latitude + raio;
            var longitudeDestinoMin = componentesDestino.Longitude;
            var longitudeDestinoMax = componentesDestino.Longitude + raio;

            var ls = lsAddressComponents.Where(x => (x.Longitude > longitudeDestinoMin && x.Longitude <= longitudeDestinoMax) && (x.Latitude > latitudeDestinoMin && x.Latitude <= latitudeDestinoMax)).ToList();

            


            return 0;
        }
    }
}
