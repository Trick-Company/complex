using System.ComponentModel.DataAnnotations;

namespace ComplexProject.Models
{
    public class SignUp
    {
        [Required]
        public string Name { get; set; }
        
        [Required]
        public string Email { get; set; }

        [Required]

        public string Password { get; set; }

        //[Compare("Password")]
        //public string ConfirmPassword { get; set; }
    }
}
