using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Xml.Linq;

namespace APIadapter.Controllers;

[Route("[controller]")]
[ApiController]

public class AdapterController : ControllerBase
{
    [HttpGet]
    public async Task<string> Get(){
        HttpClient client = new HttpClient();
        // HttpResponseMessage response = await client.GetAsync("https://www.redesocialdecidades.org.br/cities");
        HttpResponseMessage response = await client.GetAsync("https://localhost:7076/WeatherForecast");
        response.EnsureSuccessStatusCode();
        string responseBody = await response.Content.ReadAsStringAsync();
        // string json = Newtonsoft.Json.JsonConvert.SerializeObject(responseBody);
        // XNode xml = JsonConvert.DeserializeXNode(responseBody, "Cities");
        XNode xml = JsonConvert.DeserializeXNode("{\"element\":" + responseBody + "}", "root");
        return xml.ToString();
    }
}