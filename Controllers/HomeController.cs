using Microsoft.AspNetCore.Mvc;

namespace AddressBook.Controllers
{
    public class HomeController : Controller
    {
        
        // Action methods to receive HTTP requests
        public IActionResult Index(string firstName, string lastName) 
        {
            ViewData["firstName"] = firstName;
            ViewData["lastName"] = lastName;
            return View();
        }

        public IActionResult About()
        {
            return View();
        }
    }
}