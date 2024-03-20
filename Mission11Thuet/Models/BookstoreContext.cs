using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Mission11Thuet.Models
{
    // Define a partial class BookstoreContext within the Mission11Thuet.Models namespace
    public partial class BookstoreContext : DbContext
    {
        // Default constructor for the BookstoreContext class
        public BookstoreContext()
        {
        }

        // Constructor for the BookstoreContext class that takes DbContextOptions as parameter
        public BookstoreContext(DbContextOptions<BookstoreContext> options)
            : base(options)
        {
        }

        // DbSet property representing the collection of books in the database
        public virtual DbSet<Book> Books { get; set; }

        // Method invoked when configuring the DbContext options
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

            => optionsBuilder.UseSqlite("Data source=Bookstore.sqlite");

        // Method invoked when configuring the model for the DbContext
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure the entity Book
            modelBuilder.Entity<Book>(entity =>
            {
                // Create an index for the BookId property and make it unique
                entity.HasIndex(e => e.BookId, "IX_Books_BookID").IsUnique();

                // Define the property mappings for BookId and Isbn
                entity.Property(e => e.BookId).HasColumnName("BookID");
                entity.Property(e => e.Isbn).HasColumnName("ISBN");
            });

            // Invoke the partial method OnModelCreatingPartial for additional model configuration
            OnModelCreatingPartial(modelBuilder);
        }

        // Partial method for additional model configuration
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
