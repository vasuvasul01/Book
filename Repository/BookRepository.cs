using Book.API.DatabaseContext;
using Book.API.IRepository;
using Book.API.Modal;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Book.API.Repository
{
    public class BookRepository : IBookRepository
    {
        public async Task<List<tbl_Book>> GetBookDetailOrderByAuthor()
        {
            using DBContext context = new(DBContext.ops.DbOptions);
            var response = await context.Book.OrderBy(x => x.AuthorLastName).ThenBy(x => x.AuthorFirstName).ThenBy(x => x.Title).ToListAsync();
            return response;
        }

        public async Task<List<tbl_Book>> GetBookDetailOrderbyPublisher()
        {
            using DBContext context = new(DBContext.ops.DbOptions);
            var response = await context.Book.OrderBy(x => x.Publisher).ThenBy(x => x.AuthorLastName).ThenBy(x => x.AuthorFirstName).ThenBy(x => x.Title).ToListAsync();
            return response;
        }

        public async Task<List<tbl_Book>> GetSP_BookDetailOrderByAuthor()
        {
            using DBContext context = new(DBContext.ops.DbOptions);
            string ExecString = "EXEC Sp_Book @opt =2";
            return await context.Book.FromSqlRaw(ExecString).ToListAsync();
        }

        public async Task<List<tbl_Book>> GetSP_BookDetailOrderByPublisher()
        {
            using DBContext context = new(DBContext.ops.DbOptions);
            string ExecString = "EXEC Sp_Book @opt =1";
            return await context.Book.FromSqlRaw(ExecString).ToListAsync();
        }

        public int GetTotalPriceValue()
        {
            using DBContext context = new(DBContext.ops.DbOptions);
            int SumValue = context.Book.Sum(x => Convert.ToInt32(x.Price));
            return SumValue;
        }

        public string InsertBookDetailList(List<tbl_Book> tbl_Books)
        {
            using DBContext context = new(DBContext.ops.DbOptions);
            context.Book.AddRange(tbl_Books);
            return "Records saved successdully";
        }
    }
}
