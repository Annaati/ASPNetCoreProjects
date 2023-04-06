namespace Models
{
    public class CityWeather
    {

        public int SQN { get; set; }

        public string CityCode { get; set; }

        public string CityName { get; set; }

        public string CountryName { get; set; }

        public DateTime DateAndTime { get; set; }

        public int TemperatureFahrenheit { get; set; }

    }
}