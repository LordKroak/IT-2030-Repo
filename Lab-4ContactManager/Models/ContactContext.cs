using Microsoft.EntityFrameworkCore;

namespace ContactList.Models
{
    public class ContactContext : DbContext
    {
        public ContactContext(DbContextOptions<ContactContext> options)
            : base(options)
        { }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contact>().HasData(
                new Contact
                {
                    FirstName = "Delores",
                    LastName = "Del Rio",
                    Phone = 555 - 456 - 7890,
                    Email = "delores@hotmail.com",
                    CategoryId = "Fr"
                },
                new Contact
                {
                    FirstName = "Efren",
                    LastName = "Herrera",
                    Phone = 555 - 456 - 7890,
                    Email = "efren@aol.com",
                    CategoryId = "W"
                },
                new Contact
                {
                    FirstName = "Mary",
                    LastName = "Walton",
                    Phone = 555 - 123 - 4567,
                    Email = "MaryEllen@yahoo.com",
                    CategoryId = "Fm"
                }
            );
            modelBuilder.Entity<Contact>().HasData(
                new Category { CategoryId = "Fr", CatName = "Friend" },
                new Category { CategoryId = "W", CatName = "Work" },
                new Category { CategoryId = "Fm", CatName = "Family" }
            );
        }
    }
}