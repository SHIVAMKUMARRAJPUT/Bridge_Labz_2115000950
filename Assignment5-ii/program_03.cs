using System;
class program_03{
   public static void IsLeapYear(){
        Console.Write("Enter a year: ");
        int year = Convert.ToInt32(Console.ReadLine());
        if (year < 1582){
            Console.WriteLine("The LeapYear program only works for year >= 1582. Exiting...");
            return;
        }
        if (IsLeapYear(year))
            Console.WriteLine(year + " is a Leap Year.");
        else
            Console.WriteLine(year + " is not a Leap Year.");
    }

    static bool IsLeapYear(int year){
        return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
    }
}