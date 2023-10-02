using Book.API.Modal;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Book.API.IRepository
{
    public interface IBookRepository
    {
        public Task<List<tbl_Book>> GetBookDetailOrderbyPublisher();
        public Task<List<tbl_Book>> GetBookDetailOrderByAuthor();
        public Task<List<tbl_Book>> GetSP_BookDetailOrderByPublisher();
        public Task<List<tbl_Book>> GetSP_BookDetailOrderByAuthor();
        public int GetTotalPriceValue();
        public string InsertBookDetailList(List<tbl_Book> tbl_Books);
    }
}
