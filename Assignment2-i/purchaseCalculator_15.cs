using System;

class purchaseCalculator_15
{
    public static void fun()
    {
        // input for price and quantity
        Console.Write("Enter the unit price (INR): ");
        double unitPrice = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Enter the quantity: ");
        int quantity = Convert.ToInt32(Console.ReadLine());
        
        // Calculate total price
        double totalPrice = unitPrice * quantity;
        
        // Display the result
        Console.WriteLine($"The total purchase price is INR {totalPrice:F2} if the quantity {quantity} and unit price is INR {unitPrice:F2}.");
    }
}
