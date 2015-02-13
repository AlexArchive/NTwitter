using System.ComponentModel.DataAnnotations;

namespace Twitter.WebModel.Models
{
    public class RegisterModel
    {
        [Required]
        public string Username{ get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }
}