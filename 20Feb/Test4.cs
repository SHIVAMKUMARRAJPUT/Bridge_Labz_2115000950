using System;
using System.IO;

class Test4
{
    public static void Print()
    {
        if (File.Exists("example.txt"))
            Console.WriteLine("File exists.");
        else
            Console.WriteLine("File does not exist.");
    }
}
