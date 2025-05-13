using Microsoft.AspNetCore.Mvc;
using Portfolio.Models;

namespace Portfolio.Controllers
{
    public class CustomersController : Controller
    {
        public ActionResult CustomersList()
        {
            var customers = new List<Customers>
            {
                new Customers(1,"Atakan","Başol",27,"5547520870"),
                new Customers(2,"Ceren","Mutlu",28,"5434997450"),
                new Customers(3,"Batuhan","İlhan",26,"5316541113")
            };

            return View(customers); 
        }
    }
}
