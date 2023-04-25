using Entities;

namespace ServiceContracts.DTO
{
    /// <summary>
    /// Represents DTO Class that is used as return type of most methods of Persons Service 
    /// </summary>
    public class PersonRes
    {
        public Guid PersonId { get; set; }
        public Guid? CountryId { get; set; }
        public string PersonName { get; set; }
        public string? Sex { get; set; }
        public DateTime? DOB { get; set; }
        public string Country { get; set; }
        public string Email { get; set; }
        public string? Address { get; set; }
        public bool RecieveNewsLetters { get; set; }
        public double? Age { get; set; }



        /// <summary>
        /// Compare the current object data with the parameter  object data
        /// </summary>
        /// <param name="obj">The PersonRes Object to compare</param>
        /// <returns>True or False indicating weather all person details are matched with the specified parameter object</returns>
        public override bool Equals(object? obj)
        {
            if (obj == null) return false;

            if (obj != typeof(PersonRes)) return false;

            PersonRes person = (PersonRes)obj;
            return
                    PersonId == person.PersonId &&
                    CountryId == person.CountryId &
                    PersonName == person.PersonName &
                    Sex == person.Sex &
                    DOB == person.DOB &
                    Country == person.Country &
                    Email == person.Email &
                    Address == person.Address &
                    RecieveNewsLetters == person.RecieveNewsLetters &
                    Age == person.Age;
        }


        public override int GetHashCode()
        {
            return base.GetHashCode();
        }



    }



    public static class PesrsonExtensions
    {
        /// <summary>
        /// An Extension Method to convert an object of Person class into PersonRes 
        /// </summary>
        /// <param name="person">The Person object to convert</param>
        /// <returns>The PersonRes Object</returns>
        public static PersonRes ToPersonRes(this Person person)
        {
            return new PersonRes()
            {
                PersonId = person.PersonId,
                CountryId = person.CountryId,
                PersonName = person.PersonName,
                Sex = person.Sex,
                DOB = person.DOB,
                //Country = person.CountryId,
                Email = person.Email,
                Address = person.Address,
                RecieveNewsLetters = person.RecieveNewsLetters,
                Age = (person.DOB != null) ? Math.Round((DateTime.Now - person.DOB.Value).TotalDays/365.35) : null
            };
        }
    }



}
