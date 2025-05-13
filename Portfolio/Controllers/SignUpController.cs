using Microsoft.AspNetCore.Mvc;
using Portfolio.Models;

namespace Portfolio.Controllers
{
    public class SignUpController : Controller
    {
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(SignUp signUp)
        {
            if (!ModelState.IsValid)
            {
                // Eğer hata varsa, tekrar formu göster ve hataları ekranda göster
                return View(signUp);
            }
            return RedirectToAction("RegisterIsSuccess", signUp);  //başka bir action method'a yönlendirme (redirect) yapmayı sağlar.
        }
        public IActionResult RegisterIsSuccess(SignUp singUp)
        {
            return View(singUp);
        }
    }
}
