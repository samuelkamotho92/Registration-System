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

        public bool checkUser(string userVal)
        {
            string path = @"C:\\Test";
            string pathFile = @$"{path}\formOne.txt";
            if (File.Exists(pathFile))
            {
                String[] allUsers = File.ReadAllLines(pathFile);
                string[] finalArray = allUsers.Skip(1).ToArray();

                foreach (String user in finalArray)
                {
                    string[] userPass = user.Split(":");
                    if (userPass.Length < 1)
                    {
                        String userName = userPass[0].ToLower();
                        if(userVal == userName)
                        {
                            Console.WriteLine("Check user");
                            return true;

                        }
                    }
                }
            }
            Console.WriteLine("Check user null");
            return false;
        }
        public void RegisterUser()
        {
            //Allow user to enter details
            Console.WriteLine("Enter UserName");
            string userName = Console.ReadLine();
            if(userName.Length > 0)
            {
                Console.WriteLine($"Entered {userName}");

        bool isExists =  checkUser(userName);
                if (isExists)
                {
                    Console.WriteLine("UserName exists");
                    RegisterUser();
                }


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
