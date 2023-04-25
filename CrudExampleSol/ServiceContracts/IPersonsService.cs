using ServiceContracts.DTO;

namespace ServiceContracts
{
    /// <summary>
    /// Represents Business logic for manipulating Person entity
    /// </summary>
    public interface IPersonsService
    {

        /// <summary>
        /// Returns All The Persons from the list
        /// </summary>
        /// <returns>All Persons from the list as List of PersonResponse </returns>
        List<PersonRes> GetPersons();


        /// <summary>
        /// Returns a Person object based on the given Person Id
        /// </summary>
        /// <param name="PersonId">Person Id(Guid) to search</param>
        /// <returns>Matching Person as PersonResponse object</returns>
        PersonRes? GetPersonById(Guid? PersonId);


        /// <summary>
        /// Adds a Person object to the list of Persons
        /// </summary>
        /// <param name="PersonAddRequest">Person object to be added</param>
        /// <returns>Returns the Person object after adding it(including newly generated Person Id</returns>
        PersonRes AddPerson(PersonAddReq PersonAddRequest);

    }
}
