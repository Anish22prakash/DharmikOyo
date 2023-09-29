using System.ComponentModel.DataAnnotations;

namespace DharmikBackEndOyo.DB_Models
{
    public class State
    {
        [Key]
        public int StateId { get; set; }
        public string StateName { get; set; }
        public ICollection<City> Cities { get; set; }
    }
}
