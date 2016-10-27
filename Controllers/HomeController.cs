using Microsoft.AspNetCore.Mvc;

namespace AddressBook.Controllers
{
    public class HomeController : Controller
    {
        
        // Action methods to receive HTTP requests
        public IActionResult Index() 
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }
    }
}