using Microsoft.AspNetCore.Mvc;

namespace Portfolio.Controllers.Investors.ForeignInvestor
{
    public class ForeignInvestorController : Controller
    {
        public IActionResult Create()
        {
            return View();
        }
    }
}
