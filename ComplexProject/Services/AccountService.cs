using ComplexProject.Models;
using Microsoft.AspNetCore.Identity;

namespace ComplexProject.Services
{
    public class AccountService : IAccountService
    {
        UserManager<IdentityUser> usermanager;
        SignInManager<IdentityUser> signInManager;


        public AccountService(UserManager<IdentityUser> _usermanager, SignInManager<IdentityUser> _signInManager)
        {
            usermanager = _usermanager;
            signInManager = _signInManager;
        }
        public async Task<IdentityResult> CreateAccount(SignUp signUp)
        {
            IdentityUser user = new IdentityUser()
            {
                UserName = signUp.Name,
                Email = signUp.Email,
                //PasswordHash=signUp.Password,

            };

            var result = await usermanager.CreateAsync(user, signUp.Password);
            return result;
        }


        public async Task<SignInResult> SignIn(vmRegister vmRegister)
        {
            //var result = await signInManager.PasswordSignInAsync(signIn.UserName, signIn.Password, signIn.rememberMe, false);
            var result = await signInManager.PasswordSignInAsync(vmRegister.logIn.UserName, vmRegister.logIn.Password, vmRegister.logIn.rememberMe, false);
            return result;

        }




    }
}
