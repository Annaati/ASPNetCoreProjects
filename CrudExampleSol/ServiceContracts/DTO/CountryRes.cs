using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceContracts.DTO
{
    /// <summary>
    /// DTO class that is sued as return type for most CountriesService Methods
    /// </summary>
    public class CountryRes
    {
        public Guid CountryId { get; set; }
        public string? CountryName { get; set; }

        public override bool Equals(object? obj)
        {
            if (obj == null) return false;
            if (obj.GetType() != typeof(CountryRes)) return false;

            CountryRes countryToCompare = (CountryRes)obj;

            return CountryId == countryToCompare.CountryId && CountryName == countryToCompare.CountryName;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }


    public static class CountryExtensions
    {
        public static CountryRes ToCountryResponse(this Country country)
        {
            return new CountryRes() { CountryId = country.CountryId, CountryName = country.CountryName };
        }
    }

}
