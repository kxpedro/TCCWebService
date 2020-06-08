using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using WebService.Business.Consumer;
using WebService.Entities.Consumer;
using WebService.Entities.Enum;
using WebService.Entities.Models;
using WebService.Tester;

namespace WebService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CenariosController : ControllerBase
    {
        private readonly ILogger<CenariosController> _logger;

        public CenariosController(ILogger<CenariosController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public async Task<List<Comparatives>> Get(string option, int scenarioId, double acceptableParkingDistance)
        {
            ScenarioOption cenarioOption = new ScenarioOption { Option = option, ScenarioID = scenarioId };

            BestRoutesBusiness bestRoutesBusiness = new BestRoutesBusiness();
            TransportAppBusiness transportAppBusiness = new TransportAppBusiness();
            CabBusiness cabBusiness = new CabBusiness();
            ParkingBusiness parkingBusiness = new ParkingBusiness();

            CenariosTester cenariosTester = new CenariosTester();
            EstacionamentoTester estacionamentoTester = new EstacionamentoTester();

            var cenarios = cenariosTester.CriarCenariosParaTeste();
            var estacionamentos = estacionamentoTester.CriaEstacionamentosParaTeste();

            List<Comparatives> lsComparatives = new List<Comparatives>();
            List<ComparativeOptions> lsComparativeOptions = new List<ComparativeOptions>();

            if (cenarioOption.Option.Equals("transportOption"))
            {
                //Cenario
                var cenarioSelecionado = cenarios.Where(x => x.CenarioID == cenarioOption.ScenarioID).FirstOrDefault();

                List<Options> optionTraffic = await bestRoutesBusiness.GetBestRoutes(cenarioSelecionado.EnderecoOrigem, cenarioSelecionado.EnderecoDestino, cenarioSelecionado.HorarioSaida, string.Empty, "transit");
                List<Options> optionDriver = await bestRoutesBusiness.GetBestRoutes(cenarioSelecionado.EnderecoOrigem, cenarioSelecionado.EnderecoDestino, cenarioSelecionado.HorarioSaida, string.Empty, "driving");

                ComparativeOptions comparativeOptions = new ComparativeOptions();

                foreach (var item in optionTraffic)
                {
                    Comparatives comparatives = new Comparatives();
                    comparatives.AddressOrigin = new Address { StreetName = cenarioSelecionado.EnderecoOrigem };
                    comparatives.AddressDestine = new Address { StreetName = cenarioSelecionado.EnderecoDestino };
                    comparatives.Duration = item.DurationValue;
                    comparatives.Distance = item.DistanceValue;
                    comparatives.Cost = item.CostValue;
                    comparatives.TransporteType = eTransportOptions.PublicTransportation.ToString();

                    lsComparatives.Add(comparatives);
                }

                //Driver
                foreach (var item in optionDriver)
                {
                    int duration = item.DurationValue;
                    int distance = item.DistanceValue;

                    double valorTransporteAplicativo = transportAppBusiness.GetCosts(duration, distance);
                    double valorTaxi = cabBusiness.GetCosts(duration, distance, cenarioSelecionado.HorarioSaida);
                    double valorEstacionamento = parkingBusiness.GetBestCostFromAllParkings(estacionamentos, cenarioSelecionado.EnderecoDestino, cenarioSelecionado.HorarioSaida, acceptableParkingDistance).Result;

                    //Aplicativos
                    Comparatives comparativesAplicativos = new Comparatives();
                    comparativesAplicativos.AddressOrigin = new Address { StreetName = cenarioSelecionado.EnderecoOrigem };
                    comparativesAplicativos.AddressDestine = new Address { StreetName = cenarioSelecionado.EnderecoDestino };
                    comparativesAplicativos.Duration = item.DurationValue;
                    comparativesAplicativos.Distance = item.DistanceValue;
                    comparativesAplicativos.Cost = valorTransporteAplicativo;
                    comparativesAplicativos.TransporteType = eTransportOptions.TransportApp.ToString();

                    lsComparatives.Add(comparativesAplicativos);

                    //Taxi
                    Comparatives comparativesTaxi = new Comparatives();
                    comparativesTaxi.AddressOrigin = new Address { StreetName = cenarioSelecionado.EnderecoOrigem };
                    comparativesTaxi.AddressDestine = new Address { StreetName = cenarioSelecionado.EnderecoDestino };
                    comparativesTaxi.Duration = item.DurationValue;
                    comparativesTaxi.Distance = item.DistanceValue;
                    comparativesTaxi.Cost = valorTaxi;
                    comparativesTaxi.TransporteType = eTransportOptions.Cab.ToString();

                    lsComparatives.Add(comparativesTaxi);                    


                    //Estacionamentos
                    Comparatives comparativesEstacionamentos = new Comparatives();
                    comparativesEstacionamentos.AddressOrigin = new Address { StreetName = cenarioSelecionado.EnderecoOrigem };
                    comparativesEstacionamentos.AddressDestine = new Address { StreetName = cenarioSelecionado.EnderecoDestino };
                    comparativesEstacionamentos.Duration = item.DurationValue;
                    comparativesEstacionamentos.Distance = item.DistanceValue;
                    comparativesEstacionamentos.Cost = valorEstacionamento;
                    comparativesEstacionamentos.TransporteType = eTransportOptions.Driver.ToString();

                    lsComparatives.Add(comparativesEstacionamentos);
                }

                return lsComparatives;
            }
            else if (cenarioOption.Option.Equals("preferenceOption"))
            {
                //Melhor opção de transporte para cada preferencia do usuario
                List<ePreferences> preferencias = new List<ePreferences> { ePreferences.Cost, ePreferences.Distance, ePreferences.Duration };

                foreach (var prefencia in preferencias)
                {



                }


                return lsComparatives;
            }

            return null;

            //foreach (var cen in cenarios)
            //{
            //Get Google maps para transporte publico
            //List<Options> optionsTransportePublico = await bestRoutesBusiness.GetBestRoutes(cen.EnderecoOrigem, cen.EnderecoDestino, cen.HorarioSaida, "transit");                
            //foreach (var optp in optionsTransportePublico)
            //{
            //    optionValues.Add(new OptionValue { TransportOptions = eTransportOptions.PublicTransportation, Value = optp.CostValue });
            //    optionDistance.Add(new OptionDistance { TransportOptions = eTransportOptions.PublicTransportation, Value = optp.DistanceValue });
            //    optionDuration.Add(new OptionDuration { TransportOptions = eTransportOptions.PublicTransportation, Value = optp.DurationValue });
            //}                

            //Get Google maps para veiculos
            //List<Options> optionsVeiculos = await bestRoutesBusiness.GetBestRoutes(cen.EnderecoOrigem, cen.EnderecoDestino, cen.HorarioSaida, "driving");

            //Fazer estimativa de custo com aplicativos de transporte
            //Fazer estimativa de custo com taxi
            //double valorTransporteAplicativo = 0.0;
            //double valorTaxi = 0.0;

            //foreach (var opt in optionsVeiculos)
            //{
            //    valorTransporteAplicativo = transportAppBusiness.GetCosts(opt.DurationValue, opt.DistanceValue);
            //    optionValues.Add(new OptionValue { TransportOptions = eTransportOptions.TransportApp, Value = valorTransporteAplicativo });
            //    optionDistance.Add(new OptionDistance { TransportOptions = eTransportOptions.TransportApp, Value = opt.DistanceValue });
            //    optionDuration.Add(new OptionDuration { TransportOptions = eTransportOptions.TransportApp, Value = opt.DurationValue });

            //    //

            //    valorTaxi = cabBusiness.GetCosts(opt.DurationValue, opt.DistanceValue, cen.HorarioSaida);
            //    optionValues.Add(new OptionValue { TransportOptions = eTransportOptions.Cab, Value = valorTaxi });
            //    optionDistance.Add(new OptionDistance { TransportOptions = eTransportOptions.Cab, Value = opt.DistanceValue });
            //    optionDuration.Add(new OptionDuration { TransportOptions = eTransportOptions.Cab, Value = opt.DurationValue });
            //}

            //Buscar estacionamentos perto da localização de destino
            //buscar preferencias do usuario
            //foreach (var est in estacionamentos)
            //{

            //}
            //}


        }
    }
}