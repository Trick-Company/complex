using Microsoft.AspNetCore.Mvc;

namespace ComplexProject.Controllers
{
    public class CompanyController:Controller
    {
        public IActionResult Company()
        {

            return View();
        }


    }
}
