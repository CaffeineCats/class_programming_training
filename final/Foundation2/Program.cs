using System;

class Program
{
    static void Main(string[] args)
    {
        // ORDER ONE

        // Usually, at least the country is given as an option within a list when ordering online, so I made it a constant.
        const string UNITEDSTATES = "United States";

        Address addressOne = new Address("650 S 1st W", "Rexburg", "Idaho", UNITEDSTATES);

        List<Product> productsListOne = new List<Product>();

        productsListOne.Add(new Product("1", "Banana", 1.00, 5));
        productsListOne.Add(new Product("2", "Apple", 1.00, 10));
        productsListOne.Add(new Product("3", "Bananaple", 2.00, 20));

        Order orderOne = new Order(new Customer("Luis Riquelme", addressOne), productsListOne);

        // ORDER TWO
        const string CHILE = "Chile";

        Address addressTwo = new Address("Oficina Lina #239 Casa 46 Condominio Patagua", "Antofagasta", "Antofagasta", CHILE);

        List<Product> productsListTwo = new List<Product>();

        productsListTwo.Add(new Product("4", "Tomato", 1.00, 5));
        productsListTwo.Add(new Product("5", "Potato", 1.00, 10));
        productsListTwo.Add(new Product("6", "Tomopototato", 2.00, 20));

        Order orderTwo = new Order(new Customer("Luis Riquelme", addressTwo), productsListTwo);

        Console.Clear();

        //OrderOne

        Console.WriteLine(orderOne.GetPackingLabel());
        Console.WriteLine("\n-----------------------------");
        Console.WriteLine(orderOne.GetShippingLabel());
        Console.WriteLine("-----------------------------");
        Console.WriteLine(orderOne.GetOrderTotalCost());
        Console.WriteLine("-----------------------------\n");

        //OrderTwo
        Console.WriteLine(orderTwo.GetPackingLabel());
        Console.WriteLine("\n-----------------------------");
        Console.WriteLine(orderTwo.GetShippingLabel());
        Console.WriteLine("-----------------------------");
        Console.WriteLine(orderTwo.GetOrderTotalCost());
        Console.WriteLine("-----------------------------\n");


    }
}