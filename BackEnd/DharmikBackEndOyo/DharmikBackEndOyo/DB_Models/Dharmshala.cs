using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DharmikBackEndOyo.DB_Models
{
    public class Dharmshala
    {
        [Key]
        public int DharmShalaId { get; set; }

        [Required(ErrorMessage ="Please enter Dharmshala name")]
        public string DharmShalaName { get; set; }

        [Required]
        public int CityId { get; set; }
        [ForeignKey("CityId")]
        public City City { get; set; }

        [Required]
        public string DharamShalaPic { get; set; }

        [Required]
        public string Address { get; set; }

        public ICollection<DharmshalaRoomTypes> DharmshalaRoomTypes { get; set; } 

        public ICollection<Facilites> Facilites { get; set; }

        public DateTime InsertDateTime { get; set; }

        public DateTime UpdateDateTime { get; set; }
    }
}
