using System;
using System.IO;

class Test2 {
    public static void Print() {
        string content = File.ReadAllText("example.txt");
        Console.WriteLine("File Content: " + content);
    }
}
