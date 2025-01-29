using System;

public class LongestWord
{
    public static void Print()
    {
        Console.Write("Enter a sentence: ");
        string sentence = Console.ReadLine();

        string longestWord = FindLongestWord(sentence);
        Console.WriteLine($"The longest word is: {longestWord}");
    }

    static string FindLongestWord(string sentence)
    {
        string longestWord = "", currentWord = "";

        foreach (char currentChar in sentence)
        {
            if (char.IsLetterOrDigit(currentChar))
            {
                currentWord += currentChar;
            }
            else
            {
                if (currentWord.Length > longestWord.Length)
                {
                    longestWord = currentWord;
                }
                currentWord = "";
            }
        }

        if (currentWord.Length > longestWord.Length)
        {
            longestWord = currentWord;
        }

        return longestWord;
    }
}
