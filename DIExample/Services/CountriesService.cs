using IServices;

namespace Services
{
    public class CountriesService : ICountriesService
    {

        private List<string> _countries;

        public CountriesService()
        {
            _countries = new List<string>() {
                "1. Somalia",
                "2. Palestine",
                "3. Turkey",
                "4. Pakistan",
                "5. Indonesia",
                "6. Malasia",
                "7. Maldives"
            };
        }

        public List<string> GetCountries()
        {
            return _countries;
        }
    }
}