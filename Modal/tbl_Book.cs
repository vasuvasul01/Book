using System.ComponentModel.DataAnnotations;

namespace Book.API.Modal
{
    public class tbl_Book
    {
        [Key]
        public int BookId { get; set; }
        public string Publisher { get; set; }
        public string Title { get; set; }
        public string AuthorLastName { get; set; }
        public string AuthorFirstName { get; set; }
        public decimal Price { get; set; }
    }
}
