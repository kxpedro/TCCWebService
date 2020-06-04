using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebService.Business.Consumer;
using WebService.Entities.Consumer;
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

            CenariosTester cenariosTester = new CenariosTester();
            EstacionamentoTester estacionamentoTester = new EstacionamentoTester();

            var cenarios = cenariosTester.CriarCenariosParaTeste();
            var estacionamentos = estacionamentoTester.CriaEstacionamentosParaTeste();

            foreach (var cen in cenarios)
            {                
                //Get para transporte publico
                List<Options> options = await bestRoutesBusiness.GetBestRoutes(cen.EnderecoOrigem, cen.EnderecoDestino, cen.HorarioSaida, cen.TipoTransporte);

                //Get para veiculo

                //Fazer estimativa de rota com aplicativos de transporte

                //Buscar estacionamentos perto da localização de destino
                foreach (var est in estacionamentos)
                {
                    //
                }
            }

            //Retornar comparativo entre as opções
        }
    }
}