namespace Mission11Thuet.Models.ViewModels
{
    public class BookList
    {
        public IQueryable<Book> Books { get; set;}

        public PaginationInfo PaginationInfo { get; set;} = new PaginationInfo();
    }
}
