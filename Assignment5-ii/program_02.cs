using System;

class program_02{
    public static void number(){
        Console.Write("Enter a natural number: ");
        int number =Convert.ToInt32(Console.ReadLine());
        if (number <= 0){
            Console.WriteLine("Please enter a natural number (positive integer). Exiting...");
            return;
        }
        int recursiveSum = SumNaturalNumbersRecursive(number);
        int formulaSum = number * (number + 1) / 2;  
        Console.WriteLine("Sum using recursion: " + recursiveSum);
        Console.WriteLine("Sum using formula: " + formulaSum);
        Console.WriteLine("The results match: " + (recursiveSum == formulaSum));
    }

    static int SumNaturalNumbersRecursive(int n){
        if (n == 1)
            return 1;
        return n + SumNaturalNumbersRecursive(n - 1);
    }
}