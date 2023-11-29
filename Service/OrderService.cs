using Registration_System.Model;
using Registration_System.Service.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registration_System.Service
{
    public class OrderService : IOrder
    {
        public Task<string> AddOrders(Order orders)
        {
            throw new NotImplementedException();
        }

        public Task<Order> GetOrder(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Order>> GetOrders()
        {
            throw new NotImplementedException();
        }
    }
}
