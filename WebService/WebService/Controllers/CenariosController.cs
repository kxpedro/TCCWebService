using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebService.Business.Consumer;
using WebService.Entities.Consumer;
using WebService.Entities.Enum;
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
        public async void Get()
        {
            BestRoutesBusiness bestRoutesBusiness = new BestRoutesBusiness();
            TransportAppBusiness transportAppBusiness = new TransportAppBusiness();
            CabBusiness cabBusiness = new CabBusiness();

            CenariosTester cenariosTester = new CenariosTester();
            EstacionamentoTester estacionamentoTester = new EstacionamentoTester();

            var cenarios = cenariosTester.CriarCenariosParaTeste();
            var estacionamentos = estacionamentoTester.CriaEstacionamentosParaTeste();

            //Lista de Valores
            List<OptionValue> optionValues = new List<OptionValue>();
            //Lista de Distancia
            List<OptionDistance> optionDistance = new List<OptionDistance>();
            //Lista de Tempo
            List<OptionDuration> optionDuration = new List<OptionDuration>();

            foreach (var cen in cenarios)
            {
                //Get Google maps para transporte publico
                List<Options> optionsTransportePublico = await bestRoutesBusiness.GetBestRoutes(cen.EnderecoOrigem, cen.EnderecoDestino, cen.HorarioSaida, "transit");                
                foreach (var optp in optionsTransportePublico)
                {
                    optionValues.Add(new OptionValue { TransportOptions = eTransportOptions.PublicTransportation, Value = optp.CostValue });
                }                

                //Get Google maps para veiculos
                List<Options> optionsVeiculos = await bestRoutesBusiness.GetBestRoutes(cen.EnderecoOrigem, cen.EnderecoDestino, cen.HorarioSaida, "driving");

                //Fazer estimativa de custo com aplicativos de transporte
                double valorTransporteAplicativo = 0.0;
                foreach (var opt in optionsVeiculos)
                {
                    valorTransporteAplicativo = transportAppBusiness.GetCosts(opt.DurationValue, opt.DistanceValue);
                    optionValues.Add(new OptionValue { TransportOptions = eTransportOptions.TransportApp, Value = valorTransporteAplicativo });
                }

                //Fazer estimativa de custo com taxi
                double valorTaxi = 0.0;
                foreach (var opt in optionsVeiculos)
                {
                    valorTaxi = cabBusiness.GetCosts(opt.DurationValue, opt.DistanceValue, cen.HorarioSaida);
                    optionValues.Add(new OptionValue { TransportOptions = eTransportOptions.Cab, Value = valorTaxi });
                }

                //Buscar estacionamentos perto da localização de destino
                        //buscar preferencias do usuario
                foreach (var est in estacionamentos)
                {
                    
                }
            }

            //Retornar comparativo entre as opções
        }
    }
}