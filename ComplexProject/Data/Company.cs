using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ComplexProject.Data
{
   // [Table("Companies")]
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

    }
}
