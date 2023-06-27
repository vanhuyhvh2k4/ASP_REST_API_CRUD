using ASP_REST_API_CRUD.Models;
using Microsoft.EntityFrameworkCore;

namespace ASP_REST_API_CRUD.Data
{
    public class ContactsAPIDbContext : DbContext
    {
        public ContactsAPIDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Contact> Contacts { get; set; }
    }
}
