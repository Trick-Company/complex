using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ComplexProject.Data
{
    public class ComplainSuggestion
    {
        public int Id { get; set; }
        public string DescriptionText { get; set; }

        [ForeignKey("company")]
        public int Company_Id { get; set; }
        public Company company { get; set; }


    }
}
