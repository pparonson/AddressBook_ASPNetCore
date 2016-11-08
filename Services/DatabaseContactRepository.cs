using System;
using System.Collections.Generic;
using AddressBook.Models;
using AddressBook.Data;

namespace AddressBook.Services
{
    public class DatabaseContactRepository : IContactRepository
    {
        private readonly ApplicationDbContext _dbContext;
        public DatabaseContactRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void addContact(Contact contact)
        {
            _dbContext.Contacts.Add(contact);
            _dbContext.SaveChanges();
        }

        public IEnumerable<Contact> GetAllContacts()
        {
            return _dbContext.Contacts;
        }
    }
}