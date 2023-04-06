using Models;

namespace ServicesInterface
{
    public interface IWeatherService
    {

        List<CityWeather> GetWeatherDetails();
        CityWeather GetWeatherByCity(string CityCode);
    }
}