using Registration_System.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registration_System.Service.IService
{
    public interface IBook
    {
        Task<List<Book>> GetBooks();

        Task<Book> GetBooksAsync(int id);

        Task<string> AddBook(AddBook book);


        
    }
}
