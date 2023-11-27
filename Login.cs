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
            Console.WriteLine(userName);
            Console.WriteLine("Enter Password");
            string passWord = Console.ReadLine().ToLower();
            Console.WriteLine(passWord);
			/*READ USERS FROM .TXT FILE*/
			/*check if i file exist*/
			string path = @"C:\\Test";
			string pathFile = @$"{path}\formOne.txt";
			if (File.Exists(pathFile))
            {
                String[] allUsers= File.ReadAllLines(pathFile);
                foreach (String user in allUsers)
                {
                    string[] userPass= user.Split(":");
					if (userPass.Length > 1)
					{
						String username = userPass[0].ToLower();
						String password = userPass[1];
						if (userName.Equals(username) && password.Equals(passWord))
						{
							Console.WriteLine("lOGGED IN SUCCESSFULLY");
							Console.WriteLine("WELCOME " + userName);
								break;
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
	}
}
