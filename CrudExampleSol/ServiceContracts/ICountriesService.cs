using ServiceContracts.DTO;

namespace ServiceContracts
{
    /// <summary>
    /// Represents Business logic for manipulating country entity
    /// </summary>
    public interface ICountriesService
    {

        /// <summary>
        /// Returns All The Countries from the list
        /// </summary>
        /// <returns>All Countries from the list as List of countryResponse </returns>
        List<CountryRes> GetCountries();


        /// <summary>
        /// Returns a country object based on the given Country Id
        /// </summary>
        /// <param name="countryId">Country Id(Guid) to search</param>
        /// <returns>Matching Country as CountryResponse object</returns>
        CountryRes? GetCountryById(Guid? countryId);


        /// <summary>
        /// Adds a country object to the list of Countries
        /// </summary>
        /// <param name="countryAddRequest">Country object to be added</param>
        /// <returns>Returns the country object after adding it(including newly generated Country Id</returns>
        CountryRes AddCountry(CountryAddReq countryAddRequest);
        
    }
}