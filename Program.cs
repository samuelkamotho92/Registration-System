using Login_System;
using Registration_System;

Register userOne = new Register();
Login member = new Login();
Dictionary<int,string> options = new Dictionary<int,string>();
Console.WriteLine("Choose Options");
options[0] = "login";
options[1] = "Register";
foreach(KeyValuePair<int,string> option in options)
{
    Console.WriteLine($"{option.Key}: {option.Value}");
}
string userInput = Console.ReadLine();
int userChoice = int.Parse(userInput);
if (userChoice == 0)
{
    member.loginUser();
}
else if (userChoice == 1)
{
    userOne.RegisterUser();
}
else
{
    Console.WriteLine("Wrong Input Selected");
}
/*userOne.RegisterUser();*/