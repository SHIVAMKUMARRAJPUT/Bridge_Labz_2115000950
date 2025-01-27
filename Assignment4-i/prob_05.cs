
using System;
public class prob_05{
    public static void Print() {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int[] multiplicationResult = new int[4];

        for (int i = 6; i <= 9; i++)
        {
            multiplicationResult[i - 6] = number * i;
        }

        Console.WriteLine($"\nMultiplication Table of {number} (from 6 to 9):");

        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine($"{number} * {i + 6} = {multiplicationResult[i]}");
        }
    }
}




