using System.ComponentModel.DataAnnotations;

namespace ComplexProject.Data
{
    public class Field
    {
        public int Id { set; get; }
        [Required]
        public string Name { set; get; }



        public List<Company> licompany { set; get; }

    }
}
