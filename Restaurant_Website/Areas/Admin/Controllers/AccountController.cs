using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Restaurant_Website.ViewModels;

namespace Restaurant_Website.Areas.Admin.Controllers
{
    [Area("Admin")]
    //[Authorize]
    public class AccountController : Controller
    {
        //sync
        //{
        //1- Get Data
        //2- Add Data
        //3- Update Data
        //}

        //Async ==> Task ==>Await
        //{
        //*- Get Data
        //*- Add Data
        //*- Update Data
        //}



        //User Management
        //Sign In Management

        UserManager<IdentityUser> _userManager;
        SignInManager<IdentityUser> _signInManager;

        public AccountController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [AllowAnonymous]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            try
            {
                var user = await _userManager.FindByNameAsync(model.UserName);
                if (user != null)
                {
                    var result = await _signInManager.PasswordSignInAsync(user, model.Password, false, false);


                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index", "Home");
                    }
                }

                return View();
            }
            catch
            {
                return View();
            }
        }

        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction(nameof(Login));
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Register(RegisterViewModel model)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    ModelState.AddModelError("", "Password and Confirm Password must be match.");
                    return View(model);
                }




                var user = new IdentityUser
                {
                    UserName = model.UserName,
                    Email = model.Email
                };

                var result = await _userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    return RedirectToAction(nameof(Login));
                }

                return View();
            }
            catch
            {
                return View();
            }
        }

    }
}
