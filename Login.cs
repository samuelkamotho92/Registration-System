using Registration_System;
using System;
using System.Collections.Generic;
using System.Linq;
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
            if (userName.Length > 0 && password.Length > 0)
            {
                
                User user = new User();

                user.userName = userName;
                user.password = password;

                UserService userService = new UserService();
                await userService.GetUser(user.userName);
                if(user.userName==userName && user.password==password)
                {
                    return "Logged in successfully";
                }

                
            }
            else
            {
                return "";
            }


        }
    }
}
