using Demo_Product.Models;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Threading.Tasks;

namespace Demo_Product.Controllers
{
   
    public class RegisterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public RegisterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }


        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserViewRegisterModel p)
        {
            AppUser user = new AppUser()
            {
                Name = p.Name,
                Surname = p.SurName,
                UserName = p.UserNmae,
                Email = p.Mail

            };

            if(p.Password==p.ConfigrPassword)
            {
                var result = await _userManager.CreateAsync(user, p.Password);

                if(result.Succeeded)
                {
                    return RedirectToAction("Index", "Login");
                }

                else
                {
                    foreach(var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
            }

            return View(p);
        }

    }

}
