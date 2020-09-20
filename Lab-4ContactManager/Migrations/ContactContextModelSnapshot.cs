using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ContactList.Models;

namespace ContactList.Models
{
    [DbContext(typeof(ContactContext))]
    partial class ContactContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                    .HasAnnotation("ProductVersion", "3.0.0-preview5.19227.1")
                    .HasAnnotation("Relational:MaxIdentifierLength", 128)
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);
            modelBuilder.Entity("ContactManager.Models.Category", b =>
            {
                b.Property<string>("CategoryId");

                b.Property<string>("CatName");

                b.HasKey("CategoryId");

                b.ToTable("Categories");

                b.HasData(
                    new
                    {
                        CategoryId = "F",
                        CatName = "Friend"
                    },
                    new
                    {
                        CategoryId = "W",
                        CatName = "Work"
                    });
            });
            modelBuilder.Entity("ContactManager.Models.Contact", b =>
            {
                b.Property<int>("ContactId")
                    .ValueGeneratedOnAdd()
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<string>("CategoryId")
                    .IsRequired();

                b.Property<string>("FirstName")
                    .IsRequired();

                b.Property<string>("LastName")
                    .IsRequired();

                b.Property<string>("Phone")
                    .IsRequired();

                b.Property<string>("Email")
                    .IsRequired();


                b.HasKey("ContactId");

                b.HasIndex("CategoryId");

                b.ToTable("Contacts");

                b.HasData(
                    new
                    {
                        ContactId = 1,
                        CategoryId = 1,
                        FirstName = "Delores",
                        LastName = "Del Rio",
                        Phone = "555-987-6543",
                        Email = "delores@hotmail.com"
                    },
                    new
                    {
                        ContactId = 2,
                        CategoryId = 2,
                        FirstName = "Efren",
                        LastName = "Herrera",
                        Phone = "555-456-7890",
                        Email = "efren@aol.com"
                    },
                    new
                    {
                        ContactId = 3,
                        CategoryId = 3,
                        FirstName = "Mary Ellen",
                        LastName = "Walton",
                        Phone = "555-123-4567",
                        Email = "MaryEllen@yahoo.com"
                    });
            });
            modelBuilder.Entity("ContactManager.Models.Contact", b =>
            {
                b.HasOne("ContactManager.Models.Categories", "Category")
                    .WithMany()
                    .HasForeignKey("CategoryId")
                    .OnDelete(DeleteBehavior.Cascade);
            });
#pragma warning restore 612, 618
        }
    }
}