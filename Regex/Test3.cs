
using System;
using System.Text.RegularExpressions;

class Test3
    {
        static bool IsValidHexColor(string color)
        {
            string pattern = @"^#([A-Fa-f0-9]{6})$";
            return Regex.IsMatch(color, pattern);
        }

        public static void Print()
        {
            string[] testColors = { "#FFA500", "#ff4500", "#123", "#GGGGGG", "#00ff00" };

            foreach (string color in testColors)
            {
                Console.WriteLine($"{color}: {(IsValidHexColor(color) ? "Valid" : "Invalid")}");
            }
        }
    
}



