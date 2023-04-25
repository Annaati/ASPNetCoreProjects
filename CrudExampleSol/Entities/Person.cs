
namespace Entities
{
    /// <summary>
    /// Person domain model class
    /// </summary>
    public class Person
    {
        public Guid PersonId { get; set; }
        public Guid? CountryId { get; set; }
        public string PersonName { get; set; }
        public string? Sex { get; set; }
        public DateTime? DOB { get; set; }
        public string Email { get; set; }
        public string? Address { get; set; }
        public bool RecieveNewsLetters { get; set; }
    }
}
