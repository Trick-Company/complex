using System.ComponentModel.DataAnnotations;

namespace ComplexProject.Models
{
    public class LogIn
    {
        //[Required]
        public string UserName { get; set; }
        //[Required]
        public string Password { get; set; }
        public bool rememberMe { get; set; }
    }
}
