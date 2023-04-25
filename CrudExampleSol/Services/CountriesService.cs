using Entities;
using ServiceContracts;
using ServiceContracts.DTO;

namespace Services
{
    public class CountriesService : ICountriesService
    {
        private readonly List<Country> _countries;

        public CountriesService()
        {
            _countries = new List<Country>();
        }


        public List<CountryRes> GetCountries()
        {
            return _countries.Select(c=>c.ToCountryResponse()).ToList();
        }



        public CountryRes GetCountryById(Guid? countryId)
        {
            if (countryId == null) return null;

            Country? matchedCountry = _countries.FirstOrDefault(c=>c.CountryId == countryId);

            if (matchedCountry == null) return null;

            return matchedCountry.ToCountryResponse();
        }



        public CountryRes AddCountry(CountryAddReq countryAddRequest)
        {
            //Validate if countryAddRequest is null
            if (countryAddRequest == null)
            {
                throw new ArgumentNullException(nameof(CountryAddReq));
            }
            //Validate if countryAddRequest.CountryName is null
            if (countryAddRequest.CountryName == null)
            {
                throw new ArgumentException(nameof(countryAddRequest.CountryName));
            }

            //Validate if countryAddRequest.CountryName is duplicate
            if(_countries.Where(c=>c.CountryName == countryAddRequest.CountryName).Count()>0)
            {
                throw new ArgumentException("Supplied Country Name already exists");
            }

            //Converet object from CountryAddRequest to Country type
            Country country = countryAddRequest.ToCountry();

            //Generate new CountryId
            country.CountryId = Guid.NewGuid();

            //Add Country to _countries
            _countries.Add(country);

            return country.ToCountryResponse();
        }





    }
}