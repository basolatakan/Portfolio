using Microsoft.AspNetCore.Mvc;
using Portfolio.Models;
using Portfolio.Models.Inversors;

namespace Portfolio.Controllers.Investors.DomesticInvestor
{
    public class DomesticInvestorController : Controller
    {
        public IActionResult DomesticInvestorsRegister()
        {
            return View("DomesticInvestorsRegister");
        }

        [HttpPost]
        public IActionResult DomesticInvestorsRegister(DomesticInvestors domesicInvestor)
        {
            if (!ModelState.IsValid)
            {
                // Eğer hata varsa, tekrar formu göster ve hataları ekranda göster
                return View(domesicInvestor);
            }
            return RedirectToAction("DomesticRegisterIsSuccess", domesicInvestor);  //başka bir action method'a yönlendirme (redirect) yapmayı sağlar.
        }

        public IActionResult DomesticRegisterIsSuccess(DomesticInvestors domesicInvestor)
        {
            return View(domesicInvestor);
        }


    }
}
