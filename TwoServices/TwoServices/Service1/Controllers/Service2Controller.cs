using Microsoft.AspNetCore.Mvc;

namespace Service1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class Service2Controller : ControllerBase
    {
        //private static readonly string[] Summaries = new[]
        //{
        //    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        //};

        private readonly ILogger<Service2Controller> _logger;
        private readonly HttpClient _httpClient;

        public Service2Controller(ILogger<Service2Controller> logger)
        {
            _logger = logger;
            _httpClient = new HttpClient();
        }

        [HttpGet(Name = "GetService2")]
        public async Task<IEnumerable<WeatherForecast>> Get()
        {
            //Call the Service2 API to get the weather forecast and return it
            return await _httpClient.GetFromJsonAsync<IEnumerable<WeatherForecast>>("https://localhost:7122/WeatherForecast");
            //return new List<WeatherForecast>();


            //return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            //{
            //    Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            //    TemperatureC = Random.Shared.Next(-20, 55),
            //    Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            //})
            //.ToArray();
        }
    }
}
