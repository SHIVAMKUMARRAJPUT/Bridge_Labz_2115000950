using System;
using System.IO;

class Test6 {
    public static void Print() {
        if (File.Exists("example.txt")) {
            File.Copy("example.txt", "copy_example.txt", true);
            Console.WriteLine("File copied successfully.");
        } else {
            Console.WriteLine("Source file does not exist.");
        }
    }
}
