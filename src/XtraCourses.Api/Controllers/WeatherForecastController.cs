using Microsoft.AspNetCore.Mvc;
using XtraCourses.Infrastructure.services;

namespace XtraCourses.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly XtraDataClient _xtraDataClient;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, XtraDataClient xtraDataClient)
        {
            _logger = logger;
            _xtraDataClient = xtraDataClient;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public async Task<IActionResult> Get()
        {
            var client = _xtraDataClient;
            await client.GetProjectsData();

            return Ok("asd");
        }
    }
}