using System;
class prob_01{
    public static void fun(){
        // Input: Year
        Console.Write("Enter a year (>= 1582): ");
        int year = Convert.ToInt32(Console.ReadLine());

        if (year < 1582){
            Console.WriteLine("The program only works for years >= 1582.");
        }
        else{
            if (year % 4 == 0){
                if (year % 100 == 0){
                    if (year % 400 == 0){
                        Console.WriteLine($"{year} is a Leap Year.");
                    }
                    else{
                        Console.WriteLine($"{year} is not a Leap Year.");
                    }
                }
                else{
                    Console.WriteLine($"{year} is a Leap Year.");
                }
            }
            else{
                Console.WriteLine($"{year} is not a Leap Year.");
            }
        }

    }
}