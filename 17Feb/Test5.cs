using System;
using System.Linq;

class Test5{
    public static void Print(){
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        var evenNumbers = numbers.Where(n => n % 2 == 0);
        Console.WriteLine("Even Numbers:");
        foreach (var num in evenNumbers){
            Console.WriteLine(num);
        }
    }
}
