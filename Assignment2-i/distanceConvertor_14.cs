using System;
class distanceConverter_14
{
   public static void fun()
    {
        // input for distance in feet
        Console.Write("Enter the distance in feet: ");
        double distanceInFeet = Convert.ToDouble(Console.ReadLine());
        
        double distanceInYards = distanceInFeet / 3;
        double distanceInMiles = distanceInYards / 1760;
        
        // Display the result
        Console.WriteLine($"The distance in yards is {distanceInYards:F2} and in miles is {distanceInMiles:F6}.");
    }
}
