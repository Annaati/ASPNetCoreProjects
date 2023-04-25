using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace ServiceContracts.DTO
{
    public class CountryAddReq
    {
        /// <summary>
        /// DTO Class for add a new Country
        /// </summary>
        public string? CountryName { get; set; }


        public Country ToCountry()
        {
            return new Country() { CountryName = CountryName };
        }
    }
}
