using System;
class problem08{
     static void Main(){
        Console.Write("Enter the base: ");
        double baseNum = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the exponent: ");
        double exponent = Convert.ToDouble(Console.ReadLine());

        double result = Math.Pow(baseNum, exponent);
        Console.WriteLine("Result: " + result);
    }
}
