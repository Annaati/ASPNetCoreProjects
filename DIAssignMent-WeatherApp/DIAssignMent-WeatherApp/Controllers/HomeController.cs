using Microsoft.AspNetCore.Mvc;
using Models;
using ServicesInterface;

namespace DIAssignMent_WeatherApp.Controllers
{
    public class HomeController : Controller
    {
        private IWeatherService _weatherService;
        public HomeController(IWeatherService weatherService)
        {
            _weatherService = weatherService;
        }

        [Route("/")]
        public IActionResult Index()
        {

            return View(_weatherService.GetWeatherDetails());
        }

        [Route("Weather/{Citycode}")]
        public IActionResult WeatherByCity(string? CityCode)
        {
            if(string.IsNullOrWhiteSpace(CityCode))
            {
                return View();
            }

            CityWeather city = _weatherService.GetWeatherByCity(CityCode);
            return View(city);
        }


    }
}
