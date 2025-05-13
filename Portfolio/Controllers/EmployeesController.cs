using Microsoft.AspNetCore.Mvc;
using Portfolio.Models;

namespace Portfolio.Controllers
{
    public class EmployeesController : Controller
    {
        public IActionResult EmployeesList()
        {
            var employees = new List<Employees>
            {
                new Employees(1,"Ali","Veli",45,"İstanbul/Üsküdar"),
                new Employees(2,"Hüseyin","Gümüş",34,"İstanbul/Tuzla"),
                new Employees(3,"Gökhan","Yıldırım",37,"İstanbul/Maltepe")
            };
            return View(employees);
        }
    }
}
