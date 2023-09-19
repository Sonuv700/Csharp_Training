//Q 2
//Create a Class called Products with Productid, Product Name, Price. Accept 10 Products,
//sort them based on the price, and display the sorted Products 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Product
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public double Price { get; set; }

    public Product(int productId, string productName, double price)
    {
        ProductId = productId;
        ProductName = productName;
        Price = price;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create a list to store the products
        List<Product> products = new List<Product>();

        // Accept 10 products
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"\nEnter details for Product {i}:");
            Console.Write("Product ID: ");
            int productId = int.Parse(Console.ReadLine());

            Console.Write("Product Name: ");
            string productName = Console.ReadLine();

            Console.Write("Price: ");
            
            
            double price = double.Parse(Console.ReadLine());

            Product product = new Product(productId, productName, price);
            products.Add(product);
        }

        // Sort the products based on price
        products.Sort((p1, p2) => p1.Price.CompareTo(p2.Price));

        // Display the sorted products
        Console.WriteLine("\nSorted Products by Price:");
        foreach (var product in products)
        {
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine($"Product ID: {product.ProductId}, Product Name: {product.ProductName}, Price: {product.Price:C}");
            Console.ReadLine();
        }

    }
}