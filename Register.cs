using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registration_System
{
    public class Register
    {

        public void checkUser(string userVal)
        {
            string path = @"C:\\Test";
            string pathFile = @$"{path}\formOne.txt";
            if (File.Exists(pathFile))
            {
                String[] allUsers = File.ReadAllLines(pathFile);         
                foreach (String user in allUsers)
                {
                    string[] userPass = user.Split(":");
                    String userName = userPass[0].ToLower();
                    if (userName.Equals(userVal))
                    {                       
                        Console.WriteLine("User does exist,enter unique name");
                        RegisterUser();
                        break;
                    }
                }
            }
        }
        public void RegisterUser()
        {
            //Allow user to enter details
            Console.WriteLine("Enter UserName");
            string userName = Console.ReadLine();
            if(userName.Length > 0)
            {
                Console.WriteLine($"Entered {userName}");
                checkUser(userName);
                Console.WriteLine("Enter Password");
                string password = Console.ReadLine().ToLower();
                if(password.Length >= 8) {
                    Console.WriteLine($"Entered Details {userName} ${password}");
                    //Create Directorty
                    string path = @"C:\\Test";
                    Directory.CreateDirectory(path);
                    //Create File
                    string pathFile = @$"{path}\formOne.txt";
                    if (File.Exists(pathFile))
                    {
                        File.AppendAllText(pathFile,$"\n{userName}:{password}" );
                    }
                    else
                    {
                        File.WriteAllText(pathFile, $"{userName}:{password}");
                    }
                }
                else
                {
                    Console.WriteLine("Passowrd Length must be 8 and greater");
                    RegisterUser();
                }
            } else
            {
                Console.WriteLine("UserName cannot be empty");
                RegisterUser();
            }
        }
    }
}
