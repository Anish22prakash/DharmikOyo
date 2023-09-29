using System.ComponentModel.DataAnnotations;

namespace DharmikBackEndOyo.DB_Models
{
    public class DharmshalaRoomTypes
    {
        [Key]
        public int DharmshalaRoomTypesId { get; set; }
        public string DharmshalaRoomTypesName { get; set; }
        public int DharmshalaRoomTypesCost { get; set; }
        public string ImageUrl { get; set; }
        public int DharmShalaId { get; set; }
        public Dharmshala Dharmshala { get; set; }
    }
}
