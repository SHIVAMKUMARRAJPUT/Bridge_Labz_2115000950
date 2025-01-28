using System;

class NumberType
{
    public static void Print()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        int result = CheckNumberType(number);

        if (result == 1)
            Console.WriteLine("The number is positive.");
        else if (result == -1)
            Console.WriteLine("The number is negative.");
        else
            Console.WriteLine("The number is zero.");
    }

    public static int CheckNumberType(int number)
    {
        if (number > 0)
            return 1; // Positive number
        else if (number < 0)
            return -1; // Negative number
        else
            return 0; // Zero
    }
}
