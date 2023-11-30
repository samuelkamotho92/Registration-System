using Newtonsoft.Json;
using Registration_System.Model;
using Registration_System.Service.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Registration_System.Service
{
    public class UserService : IUser
    {
        private readonly HttpClient _httpClient;
        private readonly string URL = "http://localhost:3000/users";

        
        public UserService()
        {
            _httpClient = new HttpClient();
        }



        public async Task<string> AddUser(User user)
        {
            Console.WriteLine("Adding users to db");

            var content = JsonConvert.SerializeObject(user);
            var body = new StringContent(content,Encoding.UTF8,"application/json");
            var response = await _httpClient.PostAsync(URL, body);
            Console.WriteLine(response);
            if(response.IsSuccessStatusCode)
            {
                Console.WriteLine("check value");
                return "User registerd successfully";
            }
            return "";
        }

        public async Task<User> GetUser(string userName)
        {
            var response = await _httpClient.GetAsync(URL+ $"/{userName}");
            Console.WriteLine(response);


            //string
            var content = await response.Content.ReadAsStringAsync();
            
            //convert JSON string to object
            var user = JsonConvert.DeserializeObject<User>(content);

            if (response.IsSuccessStatusCode && userName != null)
            {
                Console.WriteLine(user);
            }
            else
            {
                Console.WriteLine("error occured");
            }
            return user;
        }

   

        public async Task<List<User>> GetUsers()
        {
            //Console.WriteLine("klk");

            //responce
            var resp = await _httpClient.GetAsync(URL);
            Console.WriteLine(resp);


            //string
            var content = await resp.Content.ReadAsStringAsync();
            //convert JSON string to object
            var users = JsonConvert.DeserializeObject<List<User>>(content);
            if (resp.IsSuccessStatusCode && users != null)
            {
                return users;
            }
            else
            {
                Console.WriteLine("error");
            }
            return users;

        }
    }
}
