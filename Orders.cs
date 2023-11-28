using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registration_System
{
    internal class Orders
    {
        private int orderId { get; set; }

        private int userId { get; set; }

        private int bookId { get; set; }
    }

    public Orders(int orderId, int userId, int bookId)
    {
        this.orderId = orderId;
        this.userId = userId;
        this.bookId = bookId;
    }

    public void buyBook()
    {

    }
}
