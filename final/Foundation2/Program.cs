using System;

class Program
{
    static void Main(string[] args)
    {
        Product product = new Product("007", "James Bond Action Figure", 0.07, 007);

        Console.WriteLine($"{product.GetProductLabel()} {product.GetProductTotalCost()}");
    }
}