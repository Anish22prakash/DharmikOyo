using DharmikBackEndOyo.DB_Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace DharmikBackEndOyo.Models
{
    public class City
    {
        [Key]
        public int CityId { get; set; }
        [Required(ErrorMessage = "Please enter city name")]
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
