using System.Globalization;

//variables
string name;
string product;
decimal price;
string address;

//order 1
Console.Write("Enter client name: ");
name = Console.ReadLine();

Console.Write("Enter product: ");
product = Console.ReadLine();

Console.Write("Enter price: ");
price = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.Write("Enter address: ");
address = Console.ReadLine();

Console.WriteLine($"Order No 1");
Console.WriteLine($"Client: {name}.");
Console.WriteLine($"Product: {product}, Price: {price} EUR.");
Console.WriteLine($"Adress: {address}.");

//order 2
Console.Write("Enter client name: ");
name = Console.ReadLine();

Console.Write("Enter product: ");
product = Console.ReadLine();

Console.Write("Enter price: ");
price = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.Write("Enter address: ");
address = Console.ReadLine();

Console.WriteLine($"Order No 2");
Console.WriteLine($"Client: {name}.");
Console.WriteLine($"Product: {product}, Price: {price} EUR.");
Console.WriteLine($"Adress: {address}.");

//order 3
Console.Write("Enter client name: ");
name = Console.ReadLine();

Console.Write("Enter product: ");
product = Console.ReadLine();

Console.Write("Enter price: ");
price = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.Write("Enter address: ");
address = Console.ReadLine();

Console.WriteLine($"Order No 3");
Console.WriteLine($"Client: {name}.");
Console.WriteLine($"Product: {product}, Price: {price} EUR.");
Console.WriteLine($"Adress: {address}.");