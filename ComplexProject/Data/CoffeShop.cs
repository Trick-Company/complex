using System.ComponentModel.DataAnnotations.Schema;

namespace ComplexProject.Data
{
    public class CoffeShop
    {

        public int Id { get; set; }
        public string Order { get; set; }
        public List<Employee> Li_Employee { set; get; }


    }
}
