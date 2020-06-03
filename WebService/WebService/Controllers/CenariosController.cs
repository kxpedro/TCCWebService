using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
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
        public void Get()
        {
            CenariosTester cenariosTester = new CenariosTester();

            var cenarios = cenariosTester.CriarCenariosParaTeste();

            foreach (var item in cenarios)
            {
                cenariosTester.TestarCenarioPorID(item.CenarioID);
            }



        }
    }
}