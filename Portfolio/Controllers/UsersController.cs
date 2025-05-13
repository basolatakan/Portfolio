using Microsoft.AspNetCore.Mvc;
using Portfolio.Models;

namespace Portfolio.Controllers
{
    public class UsersController : Controller
    {
        public IActionResult Users()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Users(Users model)
        {
            if (!ModelState.IsValid)
            {
                //Loglama/Kullanıcı bilgilendirme
                //ViewBag.HataMesaj = ModelState.Values.FirstOrDefault(x => x.ValidationState == Microsoft.AspNetCore.Mvc.ModelBinding.ModelValidationState.Invalid).Errors[0].ErrorMessage;

                return View(model);
            }
            else
            {
                //İşleme/Operasyona/Algoritmaya tabi tutulur
            }
            
            return View();
        }
    }
}
