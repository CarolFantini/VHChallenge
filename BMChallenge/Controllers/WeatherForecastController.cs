using System;
using BMChallenge.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using RestSharp;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BMChallenge.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IConfiguration _config;

        public WeatherForecastController(IConfiguration config)
        {
            _config = config;
        }

        // GET: api/<WeatherForecast>
        [HttpGet]
        public Forecast Get()
        {
            var baseUrl = _config.GetValue<string>("ClimaTempo:baseUrl");
            var tokenAPI = _config.GetValue<string>("ClimaTempo:token");

            var client = new RestClient(baseUrl);

            var request = new RestRequest(baseUrl, Method.GET);
            request.AddQueryParameter("token", tokenAPI);

            var response = client.Execute(request);


            var responseConverted = JsonConvert.DeserializeObject<Forecast>(response.Content);

            return responseConverted;
        }
    }
}
