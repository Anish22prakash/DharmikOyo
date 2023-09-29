using System.ComponentModel.DataAnnotations;

namespace DharmikBackEndOyo.DB_Models
{
    public class Dharmshala
    {
        [Key]
        public int DharmShalaId { get; set; }
        public string DharmshalaName { get; set; }
        public int CityId { get; set; }
        public City City { get; set; }
        public string ImageUrl { get; set; }
        public string Address { get; set; }
        public ICollection<DharmshalaRoomTypes> DharmshalaRoomTypes { get; set; } 
        public ICollection<Facilites> Facilites { get; set; } 
    }
}
