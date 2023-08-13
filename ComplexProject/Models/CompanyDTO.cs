using System.ComponentModel.DataAnnotations;

namespace ComplexProject.Models
{
    public class CompanyDTO
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please fill Company Name")]
        public string Name { get; set; }

        //public CompanyDTO companyDTO { get; set; }    //lazy loading
    }
}
