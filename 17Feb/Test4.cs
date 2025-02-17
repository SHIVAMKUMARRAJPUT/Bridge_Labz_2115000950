using System;

class Test4{
    public static void Print(){
        Func<int, int, int> add = (a, b) => a + b;
        int result = add(5, 10);
        Console.WriteLine("Sum: " + result);
    }
}
