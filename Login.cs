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
		 bool isExists = Array.Exists(allUsers, element => element.Contains(userCredential));
		       if (isExists)
				{
					if (userName.Equals("admin"))
					{
                        Books b = new Books();
                        b.createBook();
					}
					else
					{
                        Console.WriteLine("Only Admins Are Allowed");
                    }
                }
				else
				{
                    Console.WriteLine("WRONG USERNAME OR PASSWORD");
                    loginUser();
                }
			}
		}
	}
}
