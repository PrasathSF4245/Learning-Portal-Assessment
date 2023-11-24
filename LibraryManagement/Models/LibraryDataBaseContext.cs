using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using System.Net;

namespace LibraryManagement.Models
{
    public class LibraryDataBaseContext:DbContext
    {
       public DbSet<BookDetails> bookDetails { get; set; }
        public LibraryDataBaseContext(DbContextOptions<LibraryDataBaseContext> options):base(options) { }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BookDetails>().HasData(new BookDetails { BookId = 1, BookName = "DSP", Author = "Sanjay", Category = Category.MECH, Price = 1000, Published = 1983, Updated = new DateTime(2023, 11, 22), isDeleted=false }, new BookDetails { BookId = 2, BookName = "CNS", Author = "Sam", Category = Category.ECE, Price = 1000, Published = 1993, Updated = new DateTime(2023, 11, 22), isDeleted = false }, new BookDetails { BookId = 3, BookName = "AI", Author = "Ram", Category = Category.IT, Price = 1000, Published = 2013, Updated = new DateTime(2023, 11, 22), isDeleted = false });
            
        }


    }
}
