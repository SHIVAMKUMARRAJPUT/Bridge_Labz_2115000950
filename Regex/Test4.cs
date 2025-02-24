
using System;
using System.Text.RegularExpressions;

class Test4
    {
        static void ExtractEmails(string text)
        {
            string pattern = @"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,}";
            MatchCollection matches = Regex.Matches(text, pattern);

            foreach (Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
        }

        public static void Print()
        {
            string sampleText = "Contact us at support@example.com and info@company.org for more details.";
            ExtractEmails(sampleText);
        }
    
}




