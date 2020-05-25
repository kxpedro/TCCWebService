using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebService.Consuming.Classes;
using WebService.Consuming.GoogleMaps.Business;
using WebService.Entities;
using WebService.Repository;

namespace WebService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoutesController : ControllerBase
    {
        private readonly ILogger<RoutesController> _logger;

        public RoutesController(ILogger<RoutesController> logger)
        {
            _logger = logger;
        }

        public async Task<IEnumerable<RoutesJson>> GetBestRoutes(string origin, string destination)
        {
            List<RoutesJson> json = new List<RoutesJson>();
            DirectionsBusiness directionsBusiness = new DirectionsBusiness();
            MotoristaRepository motoristaRepository = new MotoristaRepository();

            MotoristaPreferencias motoristaPreferencias = motoristaRepository.GetPreferences();

            var bestRoutes = await directionsBusiness.GetBestRoutesByDirection(origin, destination, motoristaPreferencias.ArrivalTime, motoristaPreferencias.DepartureTime);


            return json;
        }
        
    }
}