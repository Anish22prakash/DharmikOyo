using System.ComponentModel.DataAnnotations;

namespace DharmikBackEndOyo.DB_Models
{
    public class Facilites
    {
        [Key]
        public int FacilitesId { get; set; }
        public string FacilitesName { get; set; }
        public int DharmShalaId { get; set; }
        public Dharmshala Dharmshala { get; set; }
    }
}
