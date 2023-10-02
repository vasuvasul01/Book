using Book.API.IRepository;
using Book.API.IService;
using Book.API.Modal;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Book.API.Service
{
    public class BookService : IBookService
    {
        private IBookRepository _bookRepository;
        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public async Task<List<tbl_Book>> GetBookDetailOrderByAuthor()
        {
            var response = await _bookRepository.GetBookDetailOrderByAuthor();
            return response;
        }

        public async Task<List<tbl_Book>> GetBookDetailOrderbyPublisher()
        {
            var response = await _bookRepository.GetBookDetailOrderbyPublisher();
            return response;
        }

        public async Task<List<tbl_Book>> GetSP_BookDetailOrderByAuthor()
        {
            var response = await _bookRepository.GetSP_BookDetailOrderByAuthor();
            return response;
        }

        public async Task<List<tbl_Book>> GetSP_BookDetailOrderByPublisher()
        {
            var response = await _bookRepository.GetSP_BookDetailOrderByPublisher();
            return response;
        }

        public int GetTotalPriceValue()
        {
            var response = _bookRepository.GetTotalPriceValue();
            return response;
        }

        public string InsertBookDetailList(List<tbl_Book> tbl_Books)
        {
            var response = _bookRepository.InsertBookDetailList(tbl_Books);
            return response;
        }
    }
}
