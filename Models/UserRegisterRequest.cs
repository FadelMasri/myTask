using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class UserRegisterRequest
    {
        [Required, EmailAddress]
        public string Email { get; set; } = string.Empty;
        [Required, MinLength(6)]
        public string Password { get; set; } = string.Empty;
        [Required, Compare("Passwordjj")]
        public string ConfirmPassword { get; set; }

    }

  
}
