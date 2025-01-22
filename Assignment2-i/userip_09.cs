class userip_09

{
    public static void dis()
    {
        Console.Write("Enter the student fee (INR): ");
        double fee = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Enter the university discount percentage: ");
        double discountPercent=Convert.ToDouble(Console.ReadLine());
        
        // Calculate discount amount
        double discount = (discountPercent / 100) * fee;
        
        // Calculate final fee after discount
        double finalFee = fee - discount;
        
        // Display the results
        Console.WriteLine($"The discount amount is INR {discount:F2} and final discounted fee is INR {finalFee:F2}.");
    }

    
}