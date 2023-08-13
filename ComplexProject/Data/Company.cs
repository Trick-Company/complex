using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ComplexProject.Data
{
    public class Company
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { set; get; }
        public string Phone { set; get; }
        public int NumOfEmployees { set; get; }
        public string floor { set; get; }

        [ForeignKey("field")]
        public int Field_Id { get; set; }
        public Field field { get; set; }

        public List<Employee> Li_Employee { set; get; }

        public List<ComplainSuggestion> Li_ComplainSuggestion { set; get; }

        [InverseProperty("Li_Company")]
        public List<GeneralServices> Li_GeneralService { set; get; }

    }
}
