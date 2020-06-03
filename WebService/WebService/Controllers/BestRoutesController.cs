using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebService.Business;
using WebService.Entities;
using WebService.Entities.Models;
using WebService.Entities.Consumer;
using WebService.Business.Consumer;

namespace WebService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BestRoutesController : ControllerBase
    {
        private readonly ILogger<BestRoutesController> _logger;

        public BestRoutesController(ILogger<BestRoutesController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public async Task<IEnumerable<TravelOptions>> Get(string origin, string destination)
        {
            MotoristaBusiness motoristaBusiness = new MotoristaBusiness();
            BestRoutesBusiness bestRoutesBusiness = new BestRoutesBusiness();

            MotoristaPreferencias motoristaPreferencias = motoristaBusiness.GetPreferencias(string.Empty);

            List<TravelOptions> lsjson = new List<TravelOptions>();
            List<Options> bestRoutes = await bestRoutesBusiness.GetBestRoutes(origin, destination, motoristaPreferencias);

            if(bestRoutes.Any())
            {            
                foreach (var br in bestRoutes)
                {
                    TravelOptions json = new TravelOptions();                

                    json.Status = "Rota encontrada";

                    lsjson.Add(json);
                }
            }
            else
            {
                TravelOptions json = new TravelOptions();
                json.Status = "Rota não encontrada.";

                lsjson.Add(json);
            }

            return lsjson;
        }
        
    }
}