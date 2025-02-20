using System;
using System.IO;

class Test2
{
    public static void Print()
    {
        foreach (string line in File.ReadLines("example.txt"))
        {
            Console.WriteLine(line);
        }
    }
}
