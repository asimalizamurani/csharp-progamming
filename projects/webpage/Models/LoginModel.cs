using System.ComponentModel.DataAnnotations;

namespace webpage.Models
{
    public class LoginModel
    {
        [Key]
        public int id { get; set; }
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string Email { get; set; }
        [StringLength(100, MinimumLength = 6, ErrorMessage = "Password should have more than 6 characters")]
        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }
    }
}
