using System.ComponentModel.DataAnnotations;

namespace LibraryMangementUi.Models
{
    public class Library
    {
        public int BookId { get; set; }
        [Display(Name = "Book Name")]
        public string BookName { get; set; }
        [Display(Name = "Author Name")]
        public string AuthorName { get; set; }
        [Display(Name = "ISBN")]
        public int ISBN { get; set; }

    }
}
