using System;
using System.ComponentModel.DataAnnotations;

namespace ContactList.Models
{
    public class Contact
    {
        // EF will instruct the database to automatically generate this value
        public int ContactId { get; set; }

        [Required(ErrorMessage = "Please enter a first name.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter a last name.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please enter a phone number.")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Please enter an email.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter a category.")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public string Organization { get; set; }
        

        public string Slug =>
            FirstName?.Replace(' ', '-').ToLower() + '-' + LastName?.Replace(' ', '-').ToLower();
    }
}

