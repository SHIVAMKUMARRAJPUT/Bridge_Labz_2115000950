using System;
class prob_11{
     public static void factorFind(){
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Factors of {number} are:");
        for (int i = 1; i < number; i++){
            if (number % i == 0){
                Console.WriteLine(i);  
            }
        }
    }
}