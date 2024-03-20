namespace Mission11Thuet.Models
{
    // Define an interface IBookRepo within the Mission11Thuet.Models namespace
    public interface IBookRepo
    {
        // Property representing a collection of books as IQueryable<Book>
        public IQueryable<Book> Books { get; }
    }
}
