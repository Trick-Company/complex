using ComplexProject.Models;
using ComplexProject.Services;
//using ComplexProject.Services;
using Microsoft.AspNetCore.Mvc;

namespace ComplexProject.Controllers
{
    public class AccountController : Controller
    {
        IAccountService accountService;

        public AccountController(IAccountService _accountService)
        {
           accountService= _accountService;
        }
        public IActionResult Login()
        {
            return View();
        }

        public async Task<IActionResult> SignUP(SignUp signUp)
        {
            var result = await accountService.CreateAccount(signUp);

            ViewData["result"] = result;

            return RedirectToAction("Privacy", "Home");

        }


        public async Task<IActionResult> CheckPassword(vmRegister vmRegister)
        {
            var result = await accountService.SignIn(vmRegister);
            if (result.Succeeded)
            {
                return RedirectToAction("Privacy", "Home");

                //var user = await accountService.getUSerInfo(signIn.Username);

                //if (user.Status == true)
                //{
                //    TempData["Name"] = user.Name;
                //    return RedirectToAction("WelcomePage", "Account");
                //}

                //else
                //{
                //    ViewData["InactiveMsg"] = "User Is inactive, call support ";
                //    return View("Login");
                //}
            }

            else
            {
                ViewData["result"] = "Invalid Username or Password";
                return View("Login");
            }
        }



        //    public async Task<IActionResult> CheckPassword(LogIn signIn)
        //    {
        //        var result = await accountService.SignIn(signIn);

        //        if (result.Succeeded)
        //        {
        //            //return View("NewField", "Feild");
        //            return RedirectToAction("NewField", "Feild");
        //        }

        //        else
        //        {
        //            ViewData["result"] = "Invalid Username or Password";
        //            return View("Login");
        //        }
        //        //if (result.Succeeded)
        //        //{
        //        //    var user = await accountService.getUSerInfo(signIn.Username);

        //        //    if (user.Status == true)
        //        //    {
        //        //        TempData["Name"] = user.Name;
        //        //        return RedirectToAction("WelcomePage", "Account");
        //        //    }

        //        //    //else
        //        //    //{
        //        //    //    ViewData["InactiveMsg"] = "User Is inactive, call support ";
        //        //    //    return View("Login");
        //        //    //}
        //        //}

        //        //else
        //        //{
        //        //    ViewData["result"] = "Invalid Username or Password";
        //        //    return View("Login");
        //        //}
        //    }

        //public IActionResult LogIn()
        //{

        //    return View();
        //}



    }
}
