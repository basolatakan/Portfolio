using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Portfolio.Models;

namespace Portfolio.Controllers
{
    public class ProductController : Controller
    {

        public ActionResult ProductList() 
        {
            var products = new List<Product>
            {
                new Product(1, "Ürün A", 5, "2022"),
                new Product(2, "Ürün B", 15, "2022"),
                new Product(3, "Ürün C", 25, "2022")
            };
            return View(products);
        }

        // GET: ProductController
        public ActionResult Stocks()
        {
            return View("Stocks");
        }

        // GET: ProductController/Details/5
        public ActionResult Details(int id)
        {
            ViewBag.ProductId = id; //.ProductId, ViewBag içinde oluşturduğun yeni bir değişkendir. Adını istediğin gibi koyabilirsin.
            return View();          //id, Details(int id) metoduna gelen parametredir.
        }

        public ActionResult Items(int id)
        {
            ViewData["ItemsList"] = new List<string> { "Item 1", "Item 2", "Item 3" };
            ViewData["SelectedItem"] = id; // Tıklanan item'ı View'e gönder
            return View();
        }

        // GET: ProductController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProductController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProductController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
