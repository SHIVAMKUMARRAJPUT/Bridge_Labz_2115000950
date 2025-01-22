using System;

class basicCalcu_11
{
    public static void fun()
    {
        // user for first number
        Console.Write("Enter first number: ");
        double number1 = Convert.ToDouble(Console.ReadLine());
        
        //  user for second number
        Console.Write("Enter second number: ");
        double number2 = Convert.ToDouble(Console.ReadLine());
        
        // arithmetic operations
        double addition = number1 + number2;
        double subtraction = number1 - number2;
        double multiplication = number1 * number2;
        double division = number2 != 0 ? number1 / number2 : double.NaN;
        
        
        Console.WriteLine($"The addition, subtraction, multiplication and division value of 2 numbers {number1} and {number2} is {addition:F2}, {subtraction:F2}, {multiplication:F2}, and {(double.IsNaN(division) ? "undefined" : division.ToString("F2"))}.");
    }
}
