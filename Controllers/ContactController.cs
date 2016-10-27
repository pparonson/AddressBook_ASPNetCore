using Microsoft.AspNetCore.Mvc;
using AddressBook.Services;

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
    }
}