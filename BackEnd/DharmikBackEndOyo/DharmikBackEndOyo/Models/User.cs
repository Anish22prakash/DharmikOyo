using System.ComponentModel.DataAnnotations;

namespace DharmikBackEndOyo.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required(ErrorMessage = "Please provide first name")]
        [MaxLength(25)]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please provide last name")]
        [MaxLength(25)]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please enter your email address")]
        public string Email { get; set; }

        public string Phone { get; set; }

        [Required(ErrorMessage = "Please enter your password")]
        public string NewPassword { get; set; }

        [Required(ErrorMessage = "Please enter your password")]
        public string ConfirmPassword { get; set; }

        public string Address { get; set; }

        public string ProfilePic { get; set; }

        public DateTime InsertDateTime { get; set; }

        public DateTime UpdateDateTime { get; set; }
    }
}
