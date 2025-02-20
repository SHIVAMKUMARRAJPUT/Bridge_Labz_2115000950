using System;
using System.IO;

class Test1
{
    public static void Print()
    {
        File.WriteAllText("example.txt", "Hello, File Handling in C#!");
        Console.WriteLine("File created and written successfully.");
    }
}
