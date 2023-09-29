using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DharmikBackEndOyo.DB_Models
{
    public class Facilites
    {
        [Key]
        public int FacilitesId { get; set; }

        [Required(ErrorMessage ="Please enter Facilites Name")]
        public string FacilitesName { get; set; }

        [Required]
        public int DharmShalaId { get; set; }

        [ForeignKey("DharmShalaId")]
        public Dharmshala Dharmshala { get; set; }

        public DateTime InsertDateTime { get; set; }

        public DateTime UpdateDateTime { get; set; }
    }
}
