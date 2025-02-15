using System;
using System.IO;

class Test3 {
    public static void Print() {
        File.AppendAllText("example.txt", "\nThis is an appended line.");
        Console.WriteLine("Data appended successfully.");
    }
}
