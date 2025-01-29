using System;

public class ReverseString
{
    public static void Print()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        string reversed = Reverse(input);

        Console.WriteLine($"Reversed String: {reversed}");
    }

    static string Reverse(string str)
    {
        char[] charArray = new char[str.Length];
        int i = 0, j = str.Length - 1;

        while (j >= 0)
        {
            charArray[i] = str[j];
            i++;
            j--;
        }

        return new string(charArray);
    }
}
