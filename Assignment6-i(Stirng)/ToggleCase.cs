using System;

public class ToggleCase
{
    public static void Print()
    {
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        string toggledString = Toggle(input);

        Console.WriteLine($"Toggled string: {toggledString}");
    }

    static string Toggle(string input)
    {
        char[] result = new char[input.Length];

        for (int i = 0; i < input.Length; i++)
        {
            char currentChar = input[i];

            result[i] = char.IsUpper(currentChar) ? char.ToLower(currentChar) :
                       char.IsLower(currentChar) ? char.ToUpper(currentChar) :
                       currentChar;
        }

        return new string(result);
    }
}
