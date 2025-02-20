using System;
using System.IO;

class Test5
{
    public static void Print()
    {
        if (File.Exists("example.txt"))
        {
            File.Delete("example.txt");
            Console.WriteLine("File deleted successfully.");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}
