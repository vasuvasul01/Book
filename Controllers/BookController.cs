using Book.API.IService;
using Book.API.Modal;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Book.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BookController : ControllerBase
    {
        private readonly IBookService _bookService;

        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet]
        [Route("GetBookDetailOrderByPulisher")]
        public async Task<List<tbl_Book>> GetBookDetailOrderByPulisher()
        {
            var response = await _bookService.GetBookDetailOrderbyPublisher();
            return response;
        }

        [HttpGet]
        [Route("GetBookDetailOrderByAuthor")]
        public async Task<List<tbl_Book>> GetBookDetailOrderByAuthor()
        {
            var response = await _bookService.GetBookDetailOrderByAuthor();
            return response;
        }

        [HttpGet]
        [Route("GetSP_BookDetailOrderByPublisher")]
        public async Task<List<tbl_Book>> GetSP_BookDetailOrderByPublisher() {
            var response = await _bookService.GetSP_BookDetailOrderByPublisher();
            return response;
        }

        [HttpGet]
        [Route("GetSP_BookDetailOrderByAuthor")]
        public async Task<List<tbl_Book>> GetSP_BookDetailOrderByAuthor()
        {
            var response = await _bookService.GetSP_BookDetailOrderByAuthor();
            return response;
        }

        [HttpGet]
        [Route("GetTotalPriceValue")]
        public int GetTotalPriceValue()
        {
            var response = _bookService.GetTotalPriceValue();
            return response;
        }

        [HttpPost]
        [Route("InsertBookDetailList")]
        public string InsertBookDetailList(List<tbl_Book> tbl_Books)
        {
            var response = _bookService.InsertBookDetailList(tbl_Books);
            return response;
        }
    }
}
