class distanc_08
{
    public static void convert()
    {
        // user for distance in kilometers
        Console.Write("Enter distance in kilometers: ");
        double km = Convert.ToDouble(Console.ReadLine());
        
        // Conversion factor: 1 mile = 1.6 km
        double miles = km / 1.6;
        
        // Display the result
        Console.WriteLine($"The total miles is {miles:F2} miles for the given {km:F2} km.");
    }

    
}