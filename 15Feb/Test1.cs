using System;
using System.IO;
class Test1 {
    public static void Print() {
        File.WriteAllText("example.txt", "Hello, this is a test file!");
        Console.WriteLine("File created and written successfully.");
    }
}
