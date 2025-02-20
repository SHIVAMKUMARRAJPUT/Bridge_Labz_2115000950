using System;
using System.IO;

class Test3
{
    public static void Print()
    {
        File.AppendAllText("example.txt", "\nAppending a new line.");
        Console.WriteLine("Text appended successfully.");
    }
}
