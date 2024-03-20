namespace Mission11Thuet.Models
{
    // Define a class EFBookRepo within the Mission11Thuet.Models namespace
    public class EFBookRepo : IBookRepo
    {
        // Private field to hold the BookstoreContext instance
        private BookstoreContext _context;

        // Constructor for EFBookRepo class that takes a BookstoreContext instance as parameter
        public EFBookRepo(BookstoreContext temp)
        {
            _context = temp;
        }

        // Property implementing the Books interface, returning IQueryable<Book> from the BookstoreContext
        public IQueryable<Book> Books => _context.Books;
    }
}
