using System;
class problem07
{
     static void Main()    {
        Console.Write("Enter the length ");
        double l = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the width ");
        double w = Convert.ToDouble(Console.ReadLine());

        double perimeter = 2 * (l + w);
        Console.WriteLine("Perimeter of the rectangle: " + perimeter);
    }
}
