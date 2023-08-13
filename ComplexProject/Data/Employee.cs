using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ComplexProject.Data
{
    public class Employee
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Gender { get; set; }
        [ForeignKey("company")]
        public int Company_Id { get; set; }
        public Company company { get; set; }


        [ForeignKey("coffeShop")]
        public int CoffeShop_Id { get; set; }
        public CoffeShop coffeShop { get; set; }


    }
}
