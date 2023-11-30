using Registration_System;
using Registration_System.Model;
using Registration_System.Service;
using Registration_System.Service.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Login_System
{
    internal class Login
    {
        public void loginUser()
        {
            Console.WriteLine("Enter Username");
            string userName=Console.ReadLine().ToLower();
            Console.WriteLine("Enter Password");
            string passWord = Console.ReadLine().ToLower();
			/*READ USERS FROM .TXT FILE*/
			/*check if i file exist*/
			string path = @"C:\\Test";
			string pathFile = @$"{path}\formOne.txt";
			if (File.Exists(pathFile))
            {
                String[] allUsers= File.ReadAllLines(pathFile);
				Console.WriteLine(allUsers);
				String userCredential = $"{userName}:{passWord}";
		 String userDetails = Array.Find(allUsers, element => element.Contains(userCredential));
		       if (userDetails!=null)
				{
					String userID = userDetails.Split(":")[0];
					Books b = new Books();


					if (userName.Equals("admin"))
					{
						b.createBook();


						/*user details*/
						/*String activeUser=*/

					}
					else
					{
                        Console.WriteLine("Only Admins Are Allowed");

						b.displayBooks(userID);
					}
                }
				else
				{
                    Console.WriteLine("WRONG USERNAME OR PASSWORD");
                    loginUser();
                }
			}
            

        }
        public async Task<string> LoginUser()

        {
            Console.WriteLine("Enter Username");
            string userName = Console.ReadLine().ToLower();
            Console.WriteLine("Enter Password");
            string password = Console.ReadLine().ToLower();
            if (userName.Length > 0 && password.Length > 0 )
            {

               // User user = new User();

                

                UserService userService = new UserService();
                List<User> members=await userService.GetUsers();

                User  member = members.Find(x => x.userName.ToLower() == userName && x.password == password);
                Console.WriteLine(member);
                if(member != null)
                {
                    if (member.userName == "userOne")
                    {
                        Console.WriteLine("add a book");
                        Books book = new Books();
                        await book.createBook();
                    }
                    else
                    {
                        Console.WriteLine("SELECTA BOOK YOU WANT TO ORDER:");
                        BookService bookService = new BookService();
                        await bookService.GetBooks();
                        Console.WriteLine("OPTION: ");

                        String user_choice = Console.ReadLine();

                        OrderService orderService = new OrderService();
                        Order order = new Order();
                        order.bookId = user_choice;
                        order.userId = $"{member.Id}";
                        await orderService.AddOrders(order);
                       


                    }
                    
                }
                else
                {
                    Console.Write("no user found");
                }
                return "user is not registered";
                
            }
            else
            {
                return "";
            }


        }
    }
}
