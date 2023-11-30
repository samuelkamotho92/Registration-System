using Registration_System.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Registration_System.Service;
namespace Registration_System
{
	

	

	public class OrdersController
    {
	



		private int orderId { get; set; }

        private int userId { get; set; }

        private int bookId { get; set; }

		private string path = @"C:\\Test";
		private string pathFile = @$"C:\\Test\orders.txt";

		public OrdersController(int userId, int bookId)
    {
            this.userId = userId;
            this.bookId = bookId;
        }

		public OrdersController()
		{

		}


		public async Task buyBook()
    {
			/*========================DISPLAYING THE AVAIABLE BOOKS================================*/
			Console.WriteLine("PLEASE ORDER A BOOK:");
			
			BookService bookService = new BookService();
			List<Book> booksList = await bookService.GetBooks();
			foreach (var book in booksList)
			{
				Console.WriteLine($"{book.Id}. {book.name}");
				/*Console.WriteLine(book);*/
			}

				Console.WriteLine("Choose option: ");
				String bookId = Console.ReadLine();

				/*
				 TODO:
						1.getting the userID from the login
				 
				 */


			if (File.Exists(pathFile))
			{
				string[] allOrders = File.ReadAllLines(pathFile);
				int noOrders = allOrders.Length;
				noOrders++;
				File.AppendAllText(pathFile, $"{noOrders}_orderID:{userId}_userID:{bookId}_bookId\n");




				OrderService orderService = new OrderService();
				Order order = new Order();
				order.bookId = $"{bookId}";
				order.userId = $"{userId}";
				orderService.AddOrders(order);
			}
			else
			{
				OrderService orderService = new OrderService();
				Order order = new Order();
				order.bookId = $"{bookId}";
				order.userId = $"{userId}";
				orderService.AddOrders(order);

				File.WriteAllText(pathFile, $"1_orderID:{userId}_userID:{bookId}_bookId");
			}


		}
	}

}
