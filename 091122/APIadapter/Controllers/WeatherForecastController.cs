using System.Xml.Linq;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace APIadapter.Controllers;

[ApiController]
[Route("[controller]")]

// Controller base es la interfaz

public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IEnumerable<WeatherForecast> Get()
    {
        var weatherForecast = Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = DateTime.Now.AddDays(index),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();

        return weatherForecast;
    }

    [HttpPost("weatherXML")]
    public string DataReciever(WeatherForecast weatherForecast)
    {
        string weatherJSON = Newtonsoft.Json.JsonConvert.SerializeObject(weatherForecast);
        XNode weatherXML = JsonConvert.DeserializeXNode(weatherJSON, "WeatherForecast");
        Console.WriteLine(weatherXML);
        return weatherXML.ToString();
    }
}
