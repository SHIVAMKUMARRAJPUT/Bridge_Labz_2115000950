using System;
class prob_02{
    public static void digitCount(){
        //  input
        Console.WriteLine("Enter a number to count the digits:");
        int number = Convert.ToInt32(Console.ReadLine());
        int count = 0;
        while (number != 0){
            // Remove the last digit
            number = number / 10;
            // Increase count by 1 
            count++;
        }

        Console.WriteLine($"The number of digits is: {count}");
    }
}
