using System.ComponentModel.DataAnnotations;

namespace DharmikBackEndOyo.DB_Models
{
    public class State
    {
        [Key]
        public int StateId { get; set; }

        [Required(ErrorMessage ="please enter state name")]
        public string StateName { get; set; }

        public ICollection<City> Cities { get; set; }

        public DateTime InsertDateTime { get; set; }

        public DateTime UpdateDateTime { get; set; }
    }
}
