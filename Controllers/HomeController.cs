using Microsoft.AspNetCore.Mvc;

namespace AddressBook.Controllers
{
    public class HomeController : Controller
    {
        
        // Action methods to receive HTTP requests
        public object Index() 
        {
            // create a new obj
            var contact = new {
                id = 1,
                firstName = "Elle",
                lastName = "Aronson",
                email = "elle.aronson@gmail.com"
            };
            return contact;
        }

        public string About()
        {
            return "This is an 'about' message";
        }
    }
}