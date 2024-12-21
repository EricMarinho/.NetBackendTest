using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

namespace WFConFin.Models
{
    public class State
    {
        public State()
        {
            Id = Guid.NewGuid();
        }

        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required (ErrorMessage = "This field is obrigatory")]
        [StringLength(2, MinimumLength = 2, ErrorMessage = "The abreviation should have 2 characters")]
        public string Abreviation { get; set; }

        [Column(TypeName = "decimal(18, 2)")]
        public decimal Area { get; set; }

        public string? FunFact { get; set; }

        //Not Required
        //public string FunFact { get; set; }
    }
}
