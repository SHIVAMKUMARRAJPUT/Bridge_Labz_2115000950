using System;

public class RemoveDuplicate
{
    public static void Print()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        string result = RemoveDuplicates(input);
        Console.WriteLine($"String after removing duplicates: {result}");
    }

    static string RemoveDuplicates(string str)
    {
        string result = "";

        foreach (char ch in str)
        {
            if (!result.Contains(ch))
            {
                result += ch;
            }
        }

        return result;
    }
}
