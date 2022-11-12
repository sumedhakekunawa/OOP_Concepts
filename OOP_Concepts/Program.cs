// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using OOP_Concepts;

Restaurant restaurant = new Restaurant("Sumedha", "Calgary", 0.15);

Console.WriteLine("{0}", restaurant.Name);
Console.WriteLine("{0}", restaurant.Address);

restaurant.GenerateReceipt(); 
Console.WriteLine("Than you for coming");