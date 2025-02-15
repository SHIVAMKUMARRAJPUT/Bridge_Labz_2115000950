using System;
using System.IO;

class Test4 {
    public static void Print() {
        if (File.Exists("example.txt")) {
            File.Delete("example.txt");
            Console.WriteLine("File deleted successfully.");
        } else {
            Console.WriteLine("File does not exist.");
        }
    }
}
