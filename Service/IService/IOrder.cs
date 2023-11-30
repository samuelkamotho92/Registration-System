using Registration_System.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registration_System.Service.IService
{
    public interface IOrder
    {
        Task<List<Order>> GetOrders();

        Task<Order>GetOrder(int id);

        Task<string> AddOrders(Order orders);

        
    }
}
