using System;

class program_12{

    public static void RandomState(){
        // Generate 5 random 4-digit numbers
        int size = 5;
        int[] randomNumbers = Generate4DigitRandomArray(size);

        // Display the generated random numbers
        Console.WriteLine("Generated Random Numbers:");
        foreach (int num in randomNumbers){
            Console.WriteLine(num);
        }
        double[] stats = FindAverageMinMax(randomNumbers);

        // Display the results
        Console.WriteLine($"\nAverage: {stats[0]:F2}");
        Console.WriteLine($"Minimum: {stats[1]}");
        Console.WriteLine($"Maximum: {stats[2]}");
    }
    // Method to generate an array of 4-digit random numbers
    public static int[] Generate4DigitRandomArray(int size){
        Random random = new Random();
        int[] randomNumbers = new int[size];

        // Generate random 4-digit numbers
        for (int i = 0; i < size; i++){
            randomNumbers[i] = random.Next(1000, 10000); // Random number between 1000 and 9999
        }

        return randomNumbers;
    }

    // Method to find the average, min, and max values of the array
    public static double[] FindAverageMinMax(int[] numbers){
        double sum = 0;
        int min = numbers[0];
        int max = numbers[0];

        // Calculate sum, min, and max
        foreach (int num in numbers){
            sum += num;
            min = Math.Min(min, num);
            max = Math.Max(max, num);
        }
        // Calculate average
        double average = sum / numbers.Length;

        // Return the average, min, and max in an array
        return new double[] { average, min, max };
    }
}
