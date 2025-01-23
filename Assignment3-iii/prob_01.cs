using System;
class prob_01
{
    public static void Armstrong()
    {
        // input
        Console.WriteLine("Enter a number to check if it is an Armstrong number:");
        int number = Convert.ToInt32(Console.ReadLine());
        int sum = 0;
        int originalNumber = number;
        while (number != 0)
        {
            // Find the last digit 
            int digit = number % 10;
            // Cube the digit and add to sum
            sum += digit * digit * digit;
            // Remove the last digit
            number = number / 10;
        }

        // if the sum is equal to the original number
        if (sum == originalNumber)
        {
            Console.WriteLine($"{originalNumber} is an Armstrong number.");
        }
        else
        {
            Console.WriteLine($"{originalNumber} is not an Armstrong number.");
        }
    }

}