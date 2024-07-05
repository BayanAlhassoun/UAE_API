using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using UAE_TheLearningHub.Core.DTO;

namespace UAE_TheLearningHub.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WeatherController : ControllerBase
    {
        [HttpGet ("{cityName}")]
        public async Task<Weather> GetWeatherByCity(string cityName)//Dubai, Irbid
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync($"https://api.openweathermap.org/data/2.5/weather?q={cityName}&appid=511ba00e6b1fdebcf7456541e7a16390&units=metric");
         var resultAsJSONString = await response.Content.ReadAsStringAsync();
                var finalResult = JsonConvert.DeserializeObject<Weather>(resultAsJSONString);
                return finalResult;
            }
        }
    }
}
