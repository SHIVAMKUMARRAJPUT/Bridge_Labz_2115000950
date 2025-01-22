using System;
class prob_07
{
    public static void fun(){
        //input from the user
        Console.Write("Enter first number: ");
        int number1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter second number: ");
        int number2 = Convert.ToInt32(Console.ReadLine());
        int temp = number1;
        number1 = number2;
        number2 = temp;
        Console.WriteLine($"The swapped numbers are {number1} and {number2}.");
    }
}