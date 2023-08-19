using ComplexProject.Models;
using Microsoft.AspNetCore.Identity;

namespace ComplexProject.Services
{
    public interface IAccountService
    {
        Task<IdentityResult> CreateAccount(SignUp signUp);
        //Task<SignInResult> SignIn(LogIn signIn);
        Task<SignInResult> SignIn(vmRegister vmRegister);
    }
}
