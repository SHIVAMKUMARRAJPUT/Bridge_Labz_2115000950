
using System;
public class prob_04{
    public static void Print()
    {
        double[] numbers = new double[10];
        double total = 0.0;
        int index = 0;

        while (index < 10)
        {
            Console.Write("Enter a number (0 or negative to stop): ");
            double input = Convert.ToDouble(Console.ReadLine());

            if (input <= 0)
            {
                break;
            }

            numbers[index] = input;
            index++;
        }

        Console.WriteLine("\nNumbers entered:");
        for (int i = 0; i < index; i++)
        {
            Console.WriteLine(numbers[i]);
            total += numbers[i];
        }

        Console.WriteLine($"\nTotal sum of numbers: {total}");
    }
}


