using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registration_System
{
    public class Orders
    {
        private int orderId { get; set; }

        private int userId { get; set; }

        private int bookId { get; set; }

		private string path = @"C:\\Test";
		private string pathFile = @$"C:\\Test\orders.txt";

		public Orders(int userId, int bookId)
    {
            this.userId = userId;
            this.bookId = bookId;
        }


	public void buyBook()
    {
          if(File.Exists(pathFile))
            {
				string[] allOrders = File.ReadAllLines(pathFile);
				int noOrders = allOrders.Length;
				noOrders++;
				File.AppendAllText(pathFile, $"{noOrders}_orderID:{userId}_userID:{bookId}_bookId\n");
            }else
            {
				File.WriteAllText (pathFile, $"1_orderID:{userId}_userID:{bookId}_bookId");
			}
            

    }
	}

}
