using Registration_System.Model;
using Registration_System.Service.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registration_System.Service
{
    public class BookService : IBook
    {
        public Task<string> AddBook(Book book)
        {
            throw new NotImplementedException();
        }

        public Task<List<Book>> GetBooks()
        {
            throw new NotImplementedException();
        }

        public Task<Book> GetBooksAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
