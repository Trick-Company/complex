using Microsoft.AspNetCore.Mvc;

namespace ComplexProject.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
