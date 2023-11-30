using Newtonsoft.Json;
using Registration_System.Model;
using Registration_System.Service.IService;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Registration_System.Service
{
	public class OrderService : IOrder
	{
		private readonly HttpClient _httpClient;
		private readonly string URL = "http://localhost:3000/orders";

		/*Constructors*/
		public OrderService()
		{
			_httpClient = new HttpClient();
		}

		public async Task<string> AddOrders(Order order)
		{

			var content = JsonConvert.SerializeObject(order);
			var body = new StringContent(content, Encoding.UTF8, "application/json");
			var response = await _httpClient.PostAsync(URL, body);
			Console.WriteLine(response);
			if (response.IsSuccessStatusCode)
			{
				return "Order Added Successfully.Thank you";
			}else
			{
				return "Server Error,Please Try Again Later";

			}
		}

		public async Task<Order> GetOrder(int id)
		{
			// Implement the logic to get a specific order by id
			throw new NotImplementedException();
		}

		public async Task<List<Order>> GetOrders()
		{
			// Response
			var resp = await _httpClient.GetAsync(URL);

			// String
			var content = await resp.Content.ReadAsStringAsync();

			// Convert JSON string to object
			var ordersList = JsonConvert.DeserializeObject<List<Order>>(content);

			if (resp.IsSuccessStatusCode && ordersList != null)
			{
				foreach (var order in ordersList) 
				{
					Console.WriteLine(order.userId);
				}
			}
			else
			{
				Console.WriteLine("error");
			}

			return ordersList;
		}
	}
}
