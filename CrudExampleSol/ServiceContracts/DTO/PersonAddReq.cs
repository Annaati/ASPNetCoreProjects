using Entities;
using ServiceContracts.Enums;
using System.ComponentModel.DataAnnotations;

namespace ServiceContracts.DTO
{
    public class PersonAddReq
    {

        [Display(Name = "Country Id")]
        public Guid? CountryId { get; set; }

        [Required(ErrorMessage = "Person Name is required")]
        [Display(Name = "Person Name")]
        public string PersonName { get; set; }

        [Required(ErrorMessage = "Person Sex is required")]
        public SexEnums? Sex { get; set; }

        [Display(Name = "Date of Birth")]
        public DateTime? DOB { get; set; }

        [Required(ErrorMessage = "Person Email is required")]
        [EmailAddress(ErrorMessage = "Email Mmust be a valid Email Address")]
        public string Email { get; set; }

        public string? Address { get; set; }

        public bool RecieveNewsLetters { get; set; }


        /// <summary>
        /// Coverts The Current of PersonAddReq into a new object of the Person type
        /// </summary>
        /// <returns>Person object</returns>
        public Person ToPerson()
        {
            return new Person()
            {
                CountryId = CountryId,
                PersonName = PersonName,
                Sex = Sex.ToString(),
                DOB = DOB,
                Email = Email,
                Address = Address,
                RecieveNewsLetters = RecieveNewsLetters
            };
        }
    }
}
