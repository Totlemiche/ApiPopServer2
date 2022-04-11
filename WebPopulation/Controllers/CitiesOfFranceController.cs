using CityOfFrance.Api;
using CityOfFrance.Api.Model;
using CityOfFrance.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebPopulation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CitiesOfFranceController : ControllerBase
    {
        private readonly ILogger<CitiesOfFranceController> _logger;
        private readonly ICitiesService _citiesService;

        public CitiesOfFranceController(ILogger<CitiesOfFranceController> logger, ICitiesService citiesService)
        {
            _logger = logger;
            _citiesService = citiesService;
        }

        [HttpGet("Cities")]
        public async Task<ActionResult<ILocation>> Get(string postalCode)
        {
            var list = await _citiesService.GetLocationsAsync(postalCode);
            
            if(list.Count() == 0)
            {
                return BadRequest("Ce code postal n'existe pas");
            }
            return Ok(list);
        }
    }
}
