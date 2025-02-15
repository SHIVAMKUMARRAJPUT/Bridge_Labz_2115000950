using System;
using System.IO;
class Test8 {
   public static void Print() {
        if (File.Exists("example.txt")) {
            string[] lines = File.ReadAllLines("example.txt");
            Console.WriteLine("File Content:");
            foreach (string line in lines) {
                Console.WriteLine(line);
            }
        } else {
            Console.WriteLine("File does not exist.");
        }
    }
}
