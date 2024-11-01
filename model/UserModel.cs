using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace webdemo.Models
{
    public class UserModel : IdentityUser
    {
        [Key]
        public int userId { get; set; }
        [Required(ErrorMessage = "First Name is required")]
        public string FirstName { get; set; }
        [Required(ErrorMessage ="Last Name is required")]
        public string LastName { get; set; }
        [EmailAddress(ErrorMessage = "Invalid email address")]
        [Required(ErrorMessage = "Email is required")]
        public string Email { get; set; }
        public string Password { get; set; }
    }
}