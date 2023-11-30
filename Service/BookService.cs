using Newtonsoft.Json;
using Registration_System.Model;
using Registration_System.Service.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Registration_System.Service
{
    public class BookService : IBook
    {
        private readonly HttpClient _httpClient;
        private readonly string URL = "http://localhost:3000/books";
        public BookService()
        {
            _httpClient = new HttpClient();
        }

        


        public async Task<string> AddBook(AddBook book)
        {
            
var content = JsonConvert.SerializeObject(book);

            var body = new StringContent(content, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync(URL, body);

            if (response.IsSuccessStatusCode)
                
            {

                return "successfully created a book";

            }

            return "";
        }

        public async Task<List<Book>> GetBooks()
        {
            var resp = await _httpClient.GetAsync(URL);

            var content = await resp.Content.ReadAsStringAsync();
            var bookList = JsonConvert.DeserializeObject<List<Book>>(content);
            if (resp.IsSuccessStatusCode && bookList != null)
            {
                foreach (var book in bookList)
                {
                    Console.WriteLine($"{book.Id} {book.name}");
                }
            }
            else
            {
                Console.WriteLine("error");
            }
            return bookList;
        }

        public async Task<Book> GetBooksAsync(int id)
        {

            throw new NotImplementedException();
        }
    }
}