using System.ComponentModel.DataAnnotations;

namespace API.Data
{
    public class LoginDto
    {
        [Required]        
        public string Username { get; set; }
        [Required]
        public string Password { get; set; }
    }
}