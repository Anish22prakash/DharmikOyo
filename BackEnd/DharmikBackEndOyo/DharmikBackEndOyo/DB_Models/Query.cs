using System.ComponentModel.DataAnnotations;

namespace DharmikBackEndOyo.DB_Models
{
    public class Query
    {
        [Key]
        public int QueryId { get; set; }
        public string Name { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public string DharmshalaRoomTypesName { get; set; }
        public int NumberOfAdultPerson { get; set; }
        public int NumberOfChildrenPerson { get; set; }
    }
}
