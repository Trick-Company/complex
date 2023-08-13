using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ComplexProject.Data
{
    public class GeneralServices
    {
        public int Id { set; get; }
        public string Description { set; get; }

        [InverseProperty("Li_GeneralService")]
        public List<Company> Li_Company { set; get; }
        


    }
}
