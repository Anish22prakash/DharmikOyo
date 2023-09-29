using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DharmikBackEndOyo.DB_Models
{
    public class City
    {
        [Key]
        public int CityId { get; set; }
        [Required(ErrorMessage ="Please enter city name")]
        public string CityName { get; set; }

        [Required]
        public int StateId { get; set; }

        [ForeignKey("StateId")]
        public State State { get; set; }

        public ICollection<Dharmshala> Dharmshalas { get; set; }

        public DateTime InsertDateTime { get; set; }

        public DateTime UpdateDateTime { get; set; }
    }
}
