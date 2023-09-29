using System.ComponentModel.DataAnnotations;

namespace DharmikBackEndOyo.DB_Models
{
    public class Query
    {
        [Key]
        public int QueryId { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Mobile { get; set; }

        [Required]
        public string Email { get; set; }

        public string Message { get; set; }

        [Required]
        public DateTime CheckInDate { get; set; }

        [Required]
        public DateTime CheckOutDate { get; set; }

        [Required]
        public string DharmshalaRoomTypesName { get; set; }

        [Required]
        public int NumberOfAdultPerson { get; set; }

        [Required]
        public int NumberOfChildrenPerson { get; set; }

        public DateTime InsertDateTime { get; set; }

        public DateTime UpdateDateTime { get; set; }
    }
}
