using Microsoft.AspNetCore.Mvc;

namespace ADEEL_WebApplication.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Shop()
        {
            TempData.Keep("pname");
            TempData.Keep("desc"); 
            TempData.Keep("price");
            return View();
        }

        public IActionResult Contacts()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View("Add");
        }

        [HttpPost]
        public IActionResult Add(string pname, string desc, string price)
        {
            if (pname != String.Empty && desc != string.Empty && price != string.Empty)
            {
                ViewData["pname"] = pname;
                ViewData["desc"] = desc;
                ViewData["price"] = price;

                ViewBag.pname = pname;
                ViewBag.desc = desc;
                ViewBag.price = price;

                TempData["pname"] = pname;
                TempData["desc"] = desc;
                TempData["price"] = price;
            }

            return View("Add");
            //return RedirectToAction("Shop");
        }
    }
}
