using Registration_System.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registration_System.Service.IService
{
    internal interface IUser
    {
        Task<List<User>> GetUsers();
        Task<User> GetUser(string userName);

        Task<string> AddUser(User user);
    }
}
