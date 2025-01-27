
using System;
public class prob_03{
    public static void Print()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number < 0)
        {
            Console.Error.WriteLine("Invalid Number.");
            Environment.Exit(0);
        }

        int[] multiplicationTable = new int[10];

        for (int i = 0; i < 10; i++)
        {
            multiplicationTable[i] = number * (i + 1);
        }

        Console.WriteLine($"\nMultiplication Table for {number}:");
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"{number} * {i + 1} = {multiplicationTable[i]}");
        }
    }
}


