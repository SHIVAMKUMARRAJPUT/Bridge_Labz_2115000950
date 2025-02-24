

using System;
using System.Text.RegularExpressions;

class Test7{
        static void ExtractLinks(string text)
        {
            string pattern = @"https?://[^\s]+";
            MatchCollection matches = Regex.Matches(text, pattern);

            foreach (Match match in matches)
            {
                Console.Write(match.Value + ", ");
            }
        }

        public static void Print()
        {
            string sampleText = "Visit https://www.google.com and http://example.org for more info.";
            Console.Write("Extracted Links: ");
            ExtractLinks(sampleText);
        }
    
}




