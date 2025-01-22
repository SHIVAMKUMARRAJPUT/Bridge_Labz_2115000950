using System;

class areaOfTriangle_12{
    public static void fun()
    {
        //  input for base and height in cm
        Console.Write("Enter the base of the triangle in cm: ");
        double baseCm = Convert.ToDouble(Console.ReadLine());
        
        Console.Write("Enter the height of the triangle in cm: ");
        double heightCm = Convert.ToDouble(Console.ReadLine());
        
       
        double areaCm2 = 0.5 * baseCm * heightCm;
        
        // Convert cm to inches 
        double baseInches = baseCm * 0.393701;
        double heightInches = heightCm * 0.393701;
        
        // Calculate area in square inches
        double areaIn2 = 0.5 * baseInches * heightInches;
        
        // Display the results
        Console.WriteLine($"The area of the triangle is {areaCm2:F2} square cm and {areaIn2:F2} square inches.");
    }
}
