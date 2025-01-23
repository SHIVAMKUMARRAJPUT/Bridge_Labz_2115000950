using System;
class prob_04
{
    public static void abundantNumber(){
        // input
        Console.WriteLine("Enter a number to check if it is an Abundant number:");
        int number = Convert.ToInt32(Console.ReadLine());
        int sum = 0;
        for (int i = 1; i < number; i++){
            if (number % i == 0){
                // Add the divisor to sum
                sum += i;
            }
        }
        // Check if sum of divisors is greater than the number
        if (sum > number){
                Console.WriteLine($"{number} is an Abundant number.");
        }else{
            Console.WriteLine($"{number} is not an Abundant number.");
        }
    }
}