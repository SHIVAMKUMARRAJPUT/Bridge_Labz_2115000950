using System;
class prob_08{
    public static void fun(){
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();
        Console.Write("Enter the starting city (fromCity): ");
        string fromCity = Console.ReadLine();
        Console.Write("Enter the via city (viaCity): ");
        string viaCity = Console.ReadLine();
        Console.Write("Enter the final destination city (toCity): ");
        string toCity = Console.ReadLine();
        Console.Write("Enter the distance from " + fromCity + " to " + viaCity + " (in miles): ");
        double fromToVia = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the distance from " + viaCity + " to " + toCity + " (in miles): ");
        double viaToFinalCity = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the total time taken for the journey (in hours): ");
        double timeTaken = Convert.ToDouble(Console.ReadLine());
        double totalDistance = fromToVia + viaToFinalCity;
        double averageSpeed = totalDistance / timeTaken;
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"The journey was from {fromCity} to {viaCity} to {toCity}. The total distance : {totalDistance} miles.");
        Console.WriteLine($"The average speed: {averageSpeed} miles per hour.");
    }
}