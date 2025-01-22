using System;
class problem05{
    static void Main() {
        Console.Write("Enter the radius");
        double radius = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the height");
        double height = Convert.ToDouble(Console.ReadLine());

        double volume = Math.PI * Math.Pow(radius, 2) * height;
        Console.WriteLine("Volume : " + volume);
    }

}
