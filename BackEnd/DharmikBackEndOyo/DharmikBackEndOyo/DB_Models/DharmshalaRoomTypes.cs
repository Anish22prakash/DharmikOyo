using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DharmikBackEndOyo.DB_Models
{
    public class DharmshalaRoomTypes
    {
        [Key]
        public int DharmshalaRoomTypesId { get; set; }

        [Required(ErrorMessage ="Please enter Dharmshala room type name")]
        public string DharmshalaRoomTypesName { get; set; }

        [Required]
        public int DharmshalaRoomTypesCost { get; set; }

        [Required]
        public string DharamShalaRoomPic { get; set; }

        [Required]
        public int DharmShalaId { get; set; }
        [ForeignKey("DharmShalaId")]
        public Dharmshala Dharmshala { get; set; }\

        public DateTime InsertDateTime { get; set; }

        public DateTime UpdateDateTime { get; set; }
    }
}
