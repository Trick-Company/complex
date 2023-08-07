using ComplexProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace ComplexProject.Controllers
{
    public class FieldController:Controller
    {


        public IActionResult Index()
        {

            return View("NewField");
        }


    }
}
