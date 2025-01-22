using System;
class prob_09{
    public static void fun(){
        Console.Write("Enter the length of side 1 (in meters): ");
        double side1 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the length of side 2 (in meters): ");
        double side2 = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the length of side 3 (in meters): ");
        double side3 = Convert.ToDouble(Console.ReadLine());
        double perimeter = side1 + side2 + side3;
        double totalDistance = 5000;
        double rounds = totalDistance / perimeter;
        Console.WriteLine($"The total number of rounds: {rounds}");
    }
}