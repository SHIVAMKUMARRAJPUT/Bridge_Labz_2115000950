
public class prob_07
{
    public static void print()
    {
        Console.WriteLine("Enter a natural number:");
        int number = Convert.ToInt32(Console.ReadLine());
        
        if (number <= 0)
        {
            Console.Error.WriteLine("Error: Please enter a natural number greater than 0.");
            return;
        }

        // Adjust array size
        int oddCount = (number + 1) / 2;  // This ensures that if the number is odd, we have one more odd number.
        int evenCount = number / 2;
        
        int[] oddNumbers = new int[oddCount];
        int[] evenNumbers = new int[evenCount];
        
        int oddIndex = 0;
        int evenIndex = 0;

        for (int i = 1; i <= number; i++)
        {
            if (i % 2 == 0)
            {
                evenNumbers[evenIndex] = i;
                evenIndex++;
            }
            else
            {
                oddNumbers[oddIndex] = i;
                oddIndex++;
            }
        }

        Console.WriteLine("\nOdd Numbers:");
        for (int i = 0; i < oddIndex; i++)
        {
            Console.Write(oddNumbers[i] + " ");
        }

        Console.WriteLine("\n\nEven Numbers:");
        for (int i = 0; i < evenIndex; i++)
        {
            Console.Write(evenNumbers[i] + " ");
        }
    }
}


