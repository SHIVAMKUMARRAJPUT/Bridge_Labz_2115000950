using System;

class rectangleSide_13
{
    public static void fun()
    {
        // input for perimeter
        Console.Write("Enter the perimeter of the square: ");
        double perimeter = Convert.ToDouble(Console.ReadLine());
        
        // Calculate the side length
        double side = perimeter / 4;
        
        // Display the result
        Console.WriteLine($"The length of the side is {side:F2} whose perimeter is {perimeter:F2}.");
    }
}
