using System;

class angle
{
    public static void Print()
    {
        // Take user input for the angle
        Console.Write("Enter the angle in degrees: ");
        double angle = Convert.ToDouble(Console.ReadLine());

        // Convert angle from degrees to radians
        double radians = Math.PI * angle / 180.0;

        // Calculate sine, cosine, and tangent
        double sine = Math.Sin(radians);
        double cosine = Math.Cos(radians);
        double tangent = Math.Tan(radians);

        // Print the results
        Console.WriteLine("Angle: " + angle + " degrees");
        Console.WriteLine("Sine: " + sine);
        Console.WriteLine("Cosine: " + cosine);
        Console.WriteLine("Tangent: " + tangent);
    }
}
