using ComplexProject.Data;
using ComplexProject.Models;

namespace ComplexProject.Sevices
{
    public class FieldService: IFieldService
    {
        ComplexContext context;
        public FieldService(ComplexContext _context) 
        {
           context = _context;

        }

        public void Insert(FieldDTO fieldDTO)
        {
            Field field =new Field();
            field.Name=fieldDTO.Name;

        }


    }
}
