using System;

class sum
{
    public static void Print()
    {
        Console.Write("Enter a number (n): ");
        int n = Convert.ToInt32(Console.ReadLine());

        int sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum += i;
        }

        Console.WriteLine($"The sum of the first {n} natural numbers is: {sum}");
    }
}