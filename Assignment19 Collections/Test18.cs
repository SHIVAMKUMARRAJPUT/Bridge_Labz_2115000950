using System;
using System.Collections.Generic;

class Test18
{
    private Dictionary<string, double> productPrices = new Dictionary<string, double>();
    private LinkedList<string> productOrder = new LinkedList<string>();
    private SortedDictionary<string, double> sortedProducts = new SortedDictionary<string, double>();

    public void AddProduct(string product, double price)
    {
        if (!productPrices.ContainsKey(product))
        {
            productPrices[product] = price;
            productOrder.AddLast(product);
            sortedProducts[product] = price;
        }
    }

    public void print()
    {
        Console.WriteLine("Shopping Cart:");
        foreach (var product in productOrder)
        {
            Console.WriteLine($"Product: {product}, Price: Rs. {productPrices[product]}");
        }
    }

    public static void Print()
    {
        Test18 cart = new Test18();
        cart.AddProduct("Laptop", 1200);
        cart.AddProduct("Phone", 800);

        cart.print();
    }
}
