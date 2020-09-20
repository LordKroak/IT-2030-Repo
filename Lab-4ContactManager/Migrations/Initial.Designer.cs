﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

using ContactList.Models;

namespace ContactList.Migrations
{
    [DbContext(typeof(ContactContext))]
    [Migration("Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0-preview5.19227.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);
            modelBuilder.Entity("Lab_4ContactManager.Models.Contact", b =>
            {
                b.Property<int>("ContactId")
                    .ValueGeneratedOnAdd()
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<string>("FirstName")
                    .IsRequired();

                b.Property<string>("LastName")
                    .IsRequired();

                b.Property<string>("Phone")
                    .IsRequired();

                b.Property<string>("Email")
                    .IsRequired();

                b.Property<string>("Organization");

                b.HasKey("ContactId");

                b.ToTable("Contacts");

                b.HasData(
                        new
                        {
                            ContactId = 1,
                            FirstName = "Delores",
                            LastName = "Del Rio",
                            Phone = "555-987-6543",
                            Email = "delores@hotmail.com"
                        },
                        new
                        {
                            ContactId = 2,
                            FirstName = "Efren",
                            LastName = "Herrera",
                            Phone = "555-456-7890",
                            Email = "efren@aol.com",
                        },
                        new
                        {
                            ContactId = 3,
                            FirstName = "Mary Ellen",
                            LastName = "Walton",
                            Phone = "555-123-5467",
                            Email = "MaryEllen@yahoo.com"
                        });
            });
#pragma warning restore 612, 618
        }
    }
}