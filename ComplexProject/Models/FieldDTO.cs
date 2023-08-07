using System.ComponentModel.DataAnnotations;

namespace ComplexProject.Models
{
    public class FieldDTO
    {
        public int Id { set; get; }
        public string Name { set; get; }

        public FieldDTO fieldDTO { get; set; }    //lazy loading
    }
}
