using System;
class prob_05{
    public static void fun(){
        // input from the user
        Console.Write("Enter temperature in Fahrenheit: ");
        double fahrenheit = Convert.ToDouble(Console.ReadLine());
        double celsiusResult = (fahrenheit - 32) * 5 / 9;

        // Print result
        Console.WriteLine($"The {fahrenheit} Fahrenheit is {celsiusResult} Celsius.");
    }
}