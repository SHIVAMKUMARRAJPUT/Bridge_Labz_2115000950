using System;
class prob_05
{
    public static void dayCalculator(){
        //input from the user
        Console.WriteLine("Enter the day of the Date:");
        int day = Convert.ToInt32(Console.ReadLine()); // day
        Console.WriteLine("Enter the day of the Month:");
        int month =Convert.ToInt32(Console.ReadLine()); // month
        Console.WriteLine("Enter the day of the Year:");
        int year = Convert.ToInt32(Console.ReadLine()); // year
        // Apply the formula to calculate the day of the week
        int y0 = year - (14 - month) / 12;
        int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
        int m0 = month + 12 * ((14 - month) / 12) - 2;
        int d0 = (day + x + 31 * m0 / 12) % 7;

        Console.WriteLine(d0);
    }
}