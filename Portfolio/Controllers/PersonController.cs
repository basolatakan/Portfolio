using Microsoft.AspNetCore.Mvc;
using Portfolio.Models;

namespace Portfolio.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult CreatePerson()
        {
            var person1 = new Person()
            {
                Email = "atakan@gmail.com",
                Password = "password123"
            };

            return View(person1);
        }

        [HttpPost]
        public IActionResult CreatePerson(Person person)
        {
            return View(person);    // Modeli tekrar View'e gönderiyoruz.
        }
    }
}
