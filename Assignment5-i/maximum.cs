using System;

class maximum
{
    public static void Print()
    {
        Console.Write("Enter three numbers: ");
        int number1 = Convert.ToInt32(Console.ReadLine());
        int number2 = Convert.ToInt32(Console.ReadLine());
        int number3 = Convert.ToInt32(Console.ReadLine());

        int[] result = FindSmallestAndLargest(number1, number2, number3);
        Console.WriteLine($"Smallest: {result[0]}, Largest: {result[1]}");
    }

    public static int[] FindSmallestAndLargest(int number1, int number2, int number3)
    {
        int smallest = Math.Min(number1, Math.Min(number2, number3));
        int largest = Math.Max(number1, Math.Max(number2, number3));
        return new int[] { smallest, largest };
    }
}
