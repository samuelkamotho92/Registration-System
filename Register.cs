using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registration_System
{
    public class Register
    {
        public void RegisterUser()
        {
            //Allow user to enter details
            Console.WriteLine("Enter UserName");

            string userName = Console.ReadLine();
            if(userName.Length > 0)
            {
                Console.WriteLine($"Entered {userName}");
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
                        File.Create(pathFile);
                        File.WriteAllText(pathFile, $"\n{userName}:{password}");

                    }




                }
            } else
            {
                Console.WriteLine("UserName cannot be empty");
            }

         /*   string userName = Console.ReadLine().ToLower();
            string password = Console.ReadLine().ToLower();
            if (userName.Length > 0 && password.Length > 8)
            {
                Console.WriteLine(userName);
                Console.WriteLine(password);
            }
            else if(userName.Length == 0)
            {
                Console.WriteLine("UserName can't be Empty");
            }else if(password.Length < 8)
            {
                Console.WriteLine("Passowrd Length must be 8 and greater");
            }*/
        }
    }
}
