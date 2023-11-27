using LibraryManagement.Models;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.IO.Pipelines;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace LibraryManagement.Controllers
{
    public class HomeController : Controller
    {
        
        private readonly IBookRepository _bookRepository;
        private readonly IWebHostEnvironment hostingEnvironment;

        public HomeController(IBookRepository bookRepository, IWebHostEnvironment hostingEnvironment)
        {
            _bookRepository = bookRepository;
            this.hostingEnvironment = hostingEnvironment;
        }

        public ViewResult Index()
        {
            var Model = _bookRepository.GetAllBooks();
            return View(Model);
        }
      
        public ViewResult AddBook()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddBook(BookDetails book)
        {
            if (ModelState.IsValid)
            {
                BookDetails newBook = new BookDetails()
                {
                    BookId = book.BookId,
                    BookName = book.BookName,
                    Author = book.Author,
                    Published = book.Published,
                    Price = book.Price,
                    Updated = book.Updated,
                    Category = book.Category,
                    isDeleted = false
                };

                _bookRepository.AddBook(newBook);

               
                return RedirectToAction("BookDetails", new { id = newBook.BookId });
            }
            return View();
        }
        public IActionResult DeleteBook(int id)
        {
            BookDetails currentBook = _bookRepository.GetBookById(id);
            if (currentBook == null || currentBook.isDeleted == true)
            {
                Response.StatusCode = 404;
                return View("BookNotFound", id);

            }
            if (currentBook.isDeleted==false)
            {
                
                _bookRepository.DeleteBook(currentBook);   
            }

            var Model = _bookRepository.GetAllBooks();
            return RedirectToAction("Index");
        }
        public ViewResult BookDetails(int id)
        {
            BookDetails currentBook= _bookRepository.GetBookById(id);
            if (currentBook == null || currentBook.isDeleted == true)
            {
                Response.StatusCode = 404;
                return View("BookNotFound", id);

            }
            return View(currentBook);
        }
        [HttpGet]
        public ViewResult EditBookDetails(int id)
        {
            BookDetails currentBook = _bookRepository.GetBookById(id);
            if (currentBook == null || currentBook.isDeleted == true)
            {
                Response.StatusCode = 404;
                return View("BookNotFound", id);

            }

            return View(currentBook);
        }
        [HttpPost]
        public IActionResult EditBookDetails(BookDetails modifiedBook)
        {
            if (ModelState.IsValid)
            {
                BookDetails book = _bookRepository.GetBookById(modifiedBook.BookId);
                book.BookName = modifiedBook.BookName;
                book.Author = modifiedBook.Author;
                book.Published = modifiedBook.Published;
                book.Price = modifiedBook.Price;
                book.Updated = modifiedBook.Updated;
                book.Category = modifiedBook.Category;

                _bookRepository.UpdateBook(book);
                return RedirectToAction("BookDetails", new { id = book.BookId });
            }
            return View("EditBookDetails", modifiedBook);
            //// return RedirectToAction("EditBookDetails");
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}