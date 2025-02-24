
using System;
using System.Text.RegularExpressions;

class Test5
    {
        static void ExtractCapitalizedWords(string text)
        {
            string pattern = @"\b[A-Z][a-z]*\b";
            MatchCollection matches = Regex.Matches(text, pattern);

            foreach (Match match in matches)
            {
                Console.Write(match.Value + ", ");
            }
        }

        public static void Print()
        {
            string sampleText = "The Eiffel Tower is in Paris and the Statue of Liberty is in New York.";
            Console.Write("Capitalized Words: ");
            ExtractCapitalizedWords(sampleText);
        }
    
}



