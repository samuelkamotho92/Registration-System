


/*using Registration_System;
using Registration_System.Service;

UserService userVal = new UserService();
await userVal.GetUsers();
Register userOne = new Register();
await userOne.RegisterUser();*/
/*    member.loginUser();*/


/*=========================ORDERS======================================================*/
using Registration_System;
using Registration_System.Service;

OrderService orderService = new OrderService();
await orderService.GetOrders();

OrdersController ordersController = new OrdersController();
await ordersController.buyBook();



/*using Login_System;
using Registration_System;
using Registration_System.Service;

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
 *//*   UserService userVal = new UserService();
    userVal.GetUsers();*/
/*    member.loginUser();*//*
}
else if (userChoice == 1)
{
  *//*  userOne.RegisterUser();*//*
}
else
{
*//*    Console.WriteLine("Wrong Input Selected");*//*
}
*//*userOne.RegisterUser();*/








