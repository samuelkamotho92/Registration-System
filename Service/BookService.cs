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


		public Task<string> AddBook(Book book)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Book>> GetBooks()
        {
			var resp = await _httpClient.GetAsync(URL);
			Console.WriteLine(resp);

			var content = await resp.Content.ReadAsStringAsync();
			var bookList = JsonConvert.DeserializeObject<List<Book>>(content);
			if (resp.IsSuccessStatusCode && bookList != null)
			{
				foreach (var book in bookList)
				{
					Console.WriteLine(book.name);
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
