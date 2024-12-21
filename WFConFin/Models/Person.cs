using System.ComponentModel.DataAnnotations;
using WFConFin.Models.Enums;

namespace WFConFin.Models
{
    public class Person
    {
        public Person()
        {
            Id = Guid.NewGuid();
            CreatedAt = DateTime.Now;
        }

        [Key]
        public Guid Id { get; set; }

        //Created at
        public DateTime CreatedAt { get; set; }

        [EmailAddress]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        public PersonType PersonType { get; set; }

        // Not Required, can be null
        public Guid? CityId { get; set; }

        // Foreign Key (Relation)
        public City City { get; set; }
    }
}
