using Entities;
using ServiceContracts;
using ServiceContracts.DTO;
using Services.Helpers;

namespace Services
{
    public class PersonsService : IPersonsService
    {


        private readonly List<Person> _persons;
        private readonly ICountriesService _countriesService;

        public PersonsService()
        {
            _persons = new List<Person>();
            _countriesService = new CountriesService();
        }

        public List<PersonRes> GetPersons()
        {
            throw new NotImplementedException();
        }


        public PersonRes? GetPersonById(Guid? PersonId)
        {
            throw new NotImplementedException();
        }


        private PersonRes ConvertPersonToPersonRes(Person person)
        {
            PersonRes personRes = person.ToPersonRes();
            personRes.Country = _countriesService.GetCountryById(person.CountryId)?.CountryName;

            return personRes;
        }
        public PersonRes AddPerson(PersonAddReq personAddReq)
        {
            //Check if personAddReq is null
            if(personAddReq== null) 
                throw new ArgumentNullException(nameof(personAddReq));

            //Validate Model
            ModelValidationHelper.ModelValidation(personAddReq);

            //Check if Email is duplcate
            if (_persons.Where(c => c.Email == personAddReq.Email).Count() > 0)
            {
                throw new ArgumentException("Supplied Email already exists");
            }

            //Convert personAddReq to Person type
            Person person = personAddReq.ToPerson();

            //Generate PersodId
            person.PersonId = Guid.NewGuid();

            //add person object to Persons list
            _persons.Add(person);

            //Convert the Person Object into PersonRes Type
           

            return ConvertPersonToPersonRes(person);
        }



    }
}
