using System;
using System.IO;

class Test7 {
    public static void Print() {
        if (File.Exists("example.txt")) {
            File.Move("example.txt", "renamed_example.txt");
            Console.WriteLine("File renamed successfully.");
        } else {
            Console.WriteLine("File does not exist.");
        }
    }
}
