using System;
using System.Collections.Generic;
using System.Linq;

public class ProductManager
{
    private List<Product> Products { get; set; } = new List<Product>();

    public void AddProduct(string name, decimal price, int stock)
    {
        Products.Add(new Product(name, price, stock));
        Console.WriteLine("Product added successfully.");
    }

    public void RemoveProduct(string name)
    {
        var product = Products.FirstOrDefault(p => p.Name.ToLower() == name.ToLower());
        if (product != null)
        {
            Products.Remove(product);
            Console.WriteLine("Product removed successfully.");
        }
        else
        {
            Console.WriteLine("Product not found.");
        }
    }

    public void SearchProductsByName(string name)
    {
        var filteredProducts = Products.Where(p => p.Name.ToLower().Contains(name.ToLower())).ToList();
        DisplayProducts(filteredProducts);
    }

    public void SearchProductsByPriceRange(decimal minPrice, decimal maxPrice)
    {
        var filteredProducts = Products.Where(p => p.Price >= minPrice && p.Price <= maxPrice).ToList();
        DisplayProducts(filteredProducts);
    }

    public void SortProductsByStock()
    {
        var sortedProducts = Products.OrderBy(p => p.Stock).ToList();
        DisplayProducts(sortedProducts);
    }

    private void DisplayProducts(List<Product> products)
    {
        if (products.Count > 0)
        {
            foreach (var product in products)
            {
                Console.WriteLine(product);
            }
        }
        else
        {
            Console.WriteLine("No products found.");
        }
    }
}
