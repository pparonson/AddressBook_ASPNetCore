using System.Collections.Generic;
using AddressBook.Models;

namespace AddressBook.Services
{
    public interface IContactRepository
    {
        IEnumerable<Contact> GetAllContacts();
    }
}