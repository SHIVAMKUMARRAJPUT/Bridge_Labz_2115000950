using System;
class program_01{
    public static void factor(){
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());        
        int[] factors = GetFactors(number);        
        Console.WriteLine("Factors: " + string.Join(", ", factors));
        Console.WriteLine("Sum of factors: " + SumOfFactors(factors));
        Console.WriteLine("Product of factors: " + ProductOfFactors(factors));
        Console.WriteLine("Sum of square of factors: " + SumOfSquareOfFactors(factors));
    }
    static int[] GetFactors(int num){
        int count = 0;
        for (int i = 1; i <= num; i++){
            if (num % i == 0)
                count++;
        }
        
        int[] factors = new int[count];
        int index = 0;
        for (int i = 1; i <= num; i++){
            if (num % i == 0)
                factors[index++] = i;
        }
        return factors;
    }

    static int SumOfFactors(int[] factors){
        int sum = 0;
        foreach (int factor in factors)
            sum += factor;
        return sum;
    }

    static int ProductOfFactors(int[] factors){
        int product = 1;
        foreach (int factor in factors)
            product *= factor;
        return product;
    }

    static int SumOfSquareOfFactors(int[] factors){
        int sum = 0;
        foreach (int factor in factors)
            sum += (int)Math.Pow(factor, 2);
        return sum;
    }
}
