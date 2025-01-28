using System;

class NumberCheck{
    // Method to check if a number is positive or negative
    public static string IsPositive(int number)
    {
        return number >= 0 ? "Positive" : "Negative";
    }

    // Method to check if a number is even or odd
    public static string IsEven(int number)
    {
        return number % 2 == 0 ? "Even" : "Odd";
    }

    // Method to compare two numbers
    public static int CompareNumbers(int number1, int number2)
    {
        if (number1 > number2)
            return 1; // number1 > number2
        else if (number1 == number2)
            return 0; // number1 == number2
        else
            return -1; // number1 < number2
    }
}

class program_09{
    public static void checker(){
        int[] numbers = new int[5];
        for (int i = 0; i < numbers.Length; i++){
            Console.Write($"Enter number {i + 1}: ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }
        for (int i = 0; i < numbers.Length; i++){
            string positivity = NumberCheck.IsPositive(numbers[i]);
            if (positivity == "Positive"){
                Console.WriteLine($"{numbers[i]} is Positive and {NumberCheck.IsEven(numbers[i])}");
            }else{
                Console.WriteLine($"{numbers[i]} is Negative");
            }
        }
        int comparisonResult = NumberCheck.CompareNumbers(numbers[0], numbers[numbers.Length - 1]);

        if (comparisonResult == 1){
            Console.WriteLine($"The first number {numbers[0]} is greater than the last number {numbers[numbers.Length - 1]}");
        }else if (comparisonResult == 0){
            Console.WriteLine($"The first number {numbers[0]} is equal to the last number {numbers[numbers.Length - 1]}");
        }else{
            Console.WriteLine($"The first number {numbers[0]} is less than the last number {numbers[numbers.Length - 1]}");
        }
    }
}
