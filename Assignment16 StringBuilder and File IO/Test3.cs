using System;
using System.Text;

class Test3{
    public static void Print(){
        Console.Write("Enter the number of strings: ");
        int n = int.Parse(Console.ReadLine());
        string[] words = new string[n];
        
        for (int i = 0; i < n; i++){
            Console.Write("Enter string " + (i + 1) + ": ");
            words[i] = Console.ReadLine();
        }
        
        string result = ConcatenateStrings(words);
        Console.WriteLine("Concatenated string: " + result);
    }

    static string ConcatenateStrings(string[] words){
        StringBuilder sb = new StringBuilder();
        foreach (string word in words){
            sb.Append(word);
        }
        return sb.ToString();
    }
}
