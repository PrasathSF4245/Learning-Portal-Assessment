namespace LibraryManagement.Models
{
    public interface IBookRepository
    {
        BookDetails GetBookById(int id);
        public IEnumerable<BookDetails> GetAllBooks();
        BookDetails AddBook(BookDetails book);
        BookDetails EditBook(BookDetails book);
        BookDetails DeleteBook(BookDetails book);
        public BookDetails UpdateBook(BookDetails book);

    }
}
