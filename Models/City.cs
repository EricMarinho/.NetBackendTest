using System.ComponentModel.DataAnnotations;

namespace WFConFin.Models
{
    public class City
    {
        public City()
        {
            Id = Guid.NewGuid();
        }
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }

        // Foreign Key (Relation)
        public State State { get; set; }
    }
}
