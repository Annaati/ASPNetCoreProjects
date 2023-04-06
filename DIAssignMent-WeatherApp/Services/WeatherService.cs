using Models;
using ServicesInterface;

namespace Services
{
    public class WeatherService : IWeatherService
    {
        private readonly List<CityWeather> _cities;

        public WeatherService()
        {
            _cities = new List<CityWeather>()
            {
                new CityWeather() {SQN=1, CityCode="MQG", CityName="Mogadishu", CountryName="Somalia", DateAndTime=Convert.ToDateTime("2023-04-06 15:00:00"), TemperatureFahrenheit = 31 },
                new CityWeather() {SQN=2,  CityCode="JRS", CityName="Jerusalem ", CountryName="Palestine", DateAndTime=Convert.ToDateTime("2023-04-06 15:00:00"), TemperatureFahrenheit = 26 },
                new CityWeather() {SQN=3,  CityCode="ANK", CityName="Ankara", CountryName="Turkey", DateAndTime=Convert.ToDateTime("2023-04-06 18:00:00"), TemperatureFahrenheit = 31 },
                new CityWeather() {SQN=4,  CityCode="ILB", CityName="Islamabad", CountryName="Pakistan", DateAndTime=Convert.ToDateTime("2023-04-06 16:00:00"), TemperatureFahrenheit = 31 },
                new CityWeather() {SQN=5,  CityCode="JKT", CityName="Jakarta", CountryName="Indonesia", DateAndTime=Convert.ToDateTime("2023-04-06 20:00:00"), TemperatureFahrenheit = 31 },
                new CityWeather() {SQN=6,  CityCode="KLP", CityName="Kuala Lumpur", CountryName="Malasia", DateAndTime=Convert.ToDateTime("2023-04-06 12:00:00"), TemperatureFahrenheit = 31 },
                new CityWeather() {SQN=7,  CityCode="MLE", CityName="Male", CountryName="Maldives", DateAndTime=Convert.ToDateTime("2023-04-06 19:00:00"), TemperatureFahrenheit = 31 }
            };
        }

        public List<CityWeather> GetWeatherDetails()
        {

            return _cities;
        }

        public CityWeather GetWeatherByCity(string CityCode)
        {
            CityWeather city =  _cities.FirstOrDefault(x => x.CityCode == CityCode);
            return city;
        }

        
    }
}