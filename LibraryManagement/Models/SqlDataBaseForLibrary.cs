namespace LibraryManagement.Models
{
    public class SqlDataBaseForLibrary : IBookRepository
    {
        private readonly LibraryDataBaseContext _context;
        public SqlDataBaseForLibrary(LibraryDataBaseContext context)
        {
            _context = context;
        }
        public BookDetails AddBook(BookDetails book)
        {
            _context.Add(book);
            _context.SaveChanges();  
            return book;    
        }

        public BookDetails DeleteBook(BookDetails book)
        {
            book.isDeleted = true;
            var bookUpdate = _context.bookDetails.Attach(book);
            bookUpdate.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return book;
        }

        public BookDetails EditBook(BookDetails book)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BookDetails> GetAllBooks()
        {
            return _context.bookDetails;
        }

        public BookDetails GetBookById(int id)
        {
            return _context.bookDetails.Find(id);
        }

        public BookDetails UpdateBook(BookDetails book)
        {
            var bookUpdate = _context.bookDetails.Attach(book);
            bookUpdate.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return book;
        }
    }
}
