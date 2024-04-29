using System;

class Program
{
    static User admin = new User("admin", "1234");
    static ProductManager productManager = new ProductManager();

    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Product Management System!");

        // Hardcoded login
        Console.Write("Enter username: ");
        string username = Console.ReadLine();
        Console.Write("Enter password: ");
        string password = Console.ReadLine();

        if (admin.Authenticate(username, password))
        {
            Console.WriteLine("Login successful!\n");
            RunMenu();
        }
        else
        {
            Console.WriteLine("Authentication failed!");
        }
    }

    static void RunMenu()
    {
        bool running = true;
        while (running)
        {
            Console.WriteLine("\n1. Add Product");
            Console.WriteLine("2. Remove Product");
            Console.WriteLine("3. Search by Name");
            Console.WriteLine("4. Search by Price Range");
            Console.WriteLine("5. Sort by Stock");
            Console.WriteLine("6. Exit");
            Console.Write("Choose an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                    AddProduct();
                    break;
                case "2":
                    RemoveProduct();
                    break;
                case "3":
                    SearchByName();
                    break;
                case "4":
                    SearchByPriceRange();
                    break;
                case "5":
                    SortByStock();
                    break;
                case "6":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

    static void AddProduct()
    {
        Console.Write("Enter product name: ");
        string name = Console.ReadLine();
        Console.Write("Enter price: ");
        decimal price = decimal.Parse(Console.ReadLine());
        Console.Write("Enter stock: ");
        int stock = int.Parse(Console.ReadLine());

        productManager.AddProduct(name, price, stock);
    }

    static void RemoveProduct()
    {
        Console.Write("Enter product name to remove: ");
        string name = Console.ReadLine();
        productManager.RemoveProduct(name);
    }

    static void SearchByName()
    {
        Console.Write("Enter product name to search: ");
        string name = Console.ReadLine();
        productManager.SearchProductsByName(name);
    }

    static void SearchByPriceRange()
    {
        Console.Write("Enter minimum price: ");
        decimal minPrice = decimal.Parse(Console.ReadLine());
        Console.Write("Enter maximum price: ");
        decimal maxPrice = decimal.Parse(Console.ReadLine());
        productManager.SearchProductsByPriceRange(minPrice, maxPrice);
    }

    static void SortByStock()
    {
        productManager.SortProductsByStock();
    }
}
