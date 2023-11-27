using System.ComponentModel.DataAnnotations;

namespace LibraryManagement.Models
{
    public enum Category 
    {
        IT=1,
        ECE,
        MECH,
        CIVIL,
    }
    public class BookDetails
    {
        [Key]
        public int BookId { get; set; }
        [Required(ErrorMessage = "Please enter the Book name.")]
        [RegularExpression("^[a-zA-Z]+$", ErrorMessage = "Only alphabetic characters are allowed.")]
        //[RegularExpression()]
        public string BookName { get; set; }
        [Required(ErrorMessage = "Please enter the Author name.")]
        [RegularExpression("^[a-zA-Z]+$", ErrorMessage = "Only alphabetic characters are allowed.")]
        public string Author { get; set; }
        [Required(ErrorMessage = "Please enter the Published year.")]
        public int? Published { get; set; }
      
        [Required(ErrorMessage = "Please enter the Price of the Book.")]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter a valid Price of the Book.")]
        public int? Price { get; set; }
        [Required(ErrorMessage = "Please enter the Updated Date of the Book.")]
        public DateTime? Updated { get; set; }

        [Required(ErrorMessage = "Please enter the Category of the Book.")]
        public Category? Category { get; set; }

        public bool isDeleted { get; set; }



    }
}
