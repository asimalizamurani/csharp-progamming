using System.ComponentModel.DataAnnotations;

namespace webpage.Models
{
    public class RegisterModel
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Username is required")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Email  is required")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }
    }
}
