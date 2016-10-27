using System;
using System.Collections.Generic;
using AddressBook.Models;

namespace AddressBook.Services
{
    public class InMemoryContactRepository : IContactRepository
    {
        private List<Contact> _contacts = new List<Contact>
        {
            new Contact { Id = 1, 
                FirstName = "Elle", 
                LastName = "Aronson",
                PhoneNumber = "7204696072",
                EmailAddress = "elle.ryan.aronson@gmail.com"
                },

            new Contact { Id = 2, 
                FirstName = "Ashley", 
                LastName = "Aronson",
                PhoneNumber = "3039024059",
                EmailAddress = "ashley.brenning@gmail.com"
                },

            new Contact { Id = 3, 
                FirstName = "Preston", 
                LastName = "Aronson",
                PhoneNumber = "7202756934",
                EmailAddress = "preston.aronson@gmail.com"
                }
        };
        public IEnumerable<Contact> GetAllContacts()
        {
            return _contacts;
        }
    }

}