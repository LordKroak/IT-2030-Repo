
namespace ContactList.Models
{
    using System;
    using Microsoft.EntityFrameworkCore;
    public class ContactContext : DbContext
    {
        public ContactContext(DbContextOptions<ContactContext> options) : base(options) {}

        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                 new Category { CategoryId = 1, CatName = "Friend" },
                 new Category { CategoryId = 2, CatName = "Work" },
                 new Category { CategoryId = 3, CatName = "Family" }
             );
            modelBuilder.Entity<Contact>().HasData(
                new Contact
                {
                    ContactId = 1,
                    FirstName = "Delores",
                    LastName = "Del Rio",
                    Phone = "555-456-7890",
                    Email = "delores@hotmail.com",
                    CategoryId = 1,
                    DateAdded = DateTime.Now
                },
                new Contact
                {
                    ContactId = 2,
                    FirstName = "Efren",
                    LastName = "Herrera",
                    Phone = "555-456-7890",
                    Email = "efren@aol.com",
                    CategoryId = 2,
                    DateAdded = DateTime.Now
                },
                new Contact
                {
                    ContactId = 3,
                    FirstName = "Mary",
                    LastName = "Walton",
                    Phone = "555-123-4567",
                    Email = "MaryEllen@yahoo.com",
                    CategoryId = 3,
                    DateAdded = DateTime.Now
                }
            );
        }
    }
}