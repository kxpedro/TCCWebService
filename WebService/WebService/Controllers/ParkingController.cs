using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace WebService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParkingController : ControllerBase
    {
        private readonly ILogger<ParkingController> _logger;

        public ParkingController(ILogger<ParkingController> logger)
        {
            _logger = logger;
        }
        
        [HttpGet]
        public void Get()
        {

        }

        [HttpPost]
        public void Post(string jsonData)
        {
            if (!string.IsNullOrWhiteSpace(jsonData))
            {
                dynamic classe = JsonConvert.DeserializeObject<object>(jsonData);



            }
        }

        [HttpPut]
        public void Put()
        {

        }

        [HttpDelete]
        public void Delete()
        {

        }

    }
}