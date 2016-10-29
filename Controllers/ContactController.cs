using Microsoft.AspNetCore.Mvc;
using AddressBook.Services;
using AddressBook.Models;

namespace AddressBook.Controllers
{
    public class ContactController : Controller 
    {
        private readonly IContactRepository _contactRepository;
        // create ctor to use DI of IContactRepository
        public ContactController(IContactRepository contactRepository )
        {
            _contactRepository = contactRepository;
        }
        public IActionResult Index()
        {
            var model = _contactRepository.GetAllContacts();
            return View(model);
        }
        /*
         * Displays view
         */
        public IActionResult Create()
        {
            return View();
        }

        /*
         * Gets POST from form; 
         */
        [HttpPost]
        public IActionResult Create(Contact contact)
        {
            /*
             * if cond checks to bind form data to contact obj
             */
             if (ModelState.IsValid)
             {
                _contactRepository.addContact(contact);
                /*
                 * Redirect to IActionResult Index to display list
                 */
                return RedirectToAction("Index");
             }

             return View(contact);
        }
        
    }
}