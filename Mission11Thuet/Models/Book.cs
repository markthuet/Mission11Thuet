using System;
using System.Collections.Generic;

namespace Mission11Thuet.Models
{
    // Define a partial class Book within the Mission11Thuet.Models namespace
    public partial class Book
    {
        // Property representing the Book ID
        public int BookId { get; set; }

        // Property representing the title of the book
        public string Title { get; set; } = null!;

        // Property representing the author of the book
        public string Author { get; set; } = null!;

        // Property representing the publisher of the book
        public string Publisher { get; set; } = null!;

        // Property representing the ISBN (International Standard Book Number) of the book
        public string Isbn { get; set; } = null!;

        // Property representing the classification of the book
        public string Classification { get; set; } = null!;

        // Property representing the category of the book
        public string Category { get; set; } = null!;

        // Property representing the number of pages in the book
        public int PageCount { get; set; }

        // Property representing the price of the book
        public double Price { get; set; }
    }
}
