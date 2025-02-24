using System;
using System.Text.RegularExpressions;
class Test8{
        static string ReplaceMultipleSpaces(string text)
        {
            return Regex.Replace(text, @"\s+", " ").Trim();
        }

        public static void Print()
        {
            string input = "This   is  an   example    with multiple    spaces.";
            string output = ReplaceMultipleSpaces(input);
            Console.WriteLine($"Original: \"{input}\"");
            Console.WriteLine($"Processed: \"{output}\"");
        }
    
}



