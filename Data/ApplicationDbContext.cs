using Microsoft.EntityFrameworkCore;
using AddressBook.Models;

namespace AddressBook.Data 
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(
            DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Contact> Contacts {get;set;}
    }
}