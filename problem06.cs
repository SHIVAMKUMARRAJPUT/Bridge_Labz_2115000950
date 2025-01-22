using System;
class problem06{
     static void Main() {
        Console.Write("Enter the principal amount: ");
        double p = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the rate  ");
        double r = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the time in years: ");
        double t = Convert.ToDouble(Console.ReadLine());

        double si = (p * r * t) / 100;
        Console.WriteLine("Simple Interest: " + si);
    }
    
}
