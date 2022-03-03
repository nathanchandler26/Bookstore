using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Bookstore.Models
{
    public partial class Book
    {
        [Key]
        [Required]
        public long BookId { get; set; }

        [Required(ErrorMessage = "Please enter a book title")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Please enter the book author")]
        public string Author { get; set; }

        [Required(ErrorMessage = "Please enter the book publisher")]
        public string Publisher { get; set; }

        [Required(ErrorMessage = "Please enter the book ISBN")]
        public string Isbn { get; set; }

        [Required(ErrorMessage = "Please enter the book classification")]
        public string Classification { get; set; }

        [Required(ErrorMessage = "Please enter the book category")]
        public string Category { get; set; }

        [Required]
        public long PageCount { get; set; }

        [Required]
        public double Price { get; set; }
    }
    //Validation for creating/editing a book, make each field required. Error messages for every field but the integers, they default to 0
}
