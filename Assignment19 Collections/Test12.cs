using System;
using System.Collections.Generic;

class Test12{
    public static void Print(){
        int N = 5;
        List<string> binaryNumbers = GenerateBinaryNumbers(N);

        Console.WriteLine("Binary Numbers: {" + String.Join(", ", binaryNumbers) + "}");
    }

    static List<string> GenerateBinaryNumbers(int N){
        Queue<string> queue = new Queue<string>();
        List<string> result = new List<string>();
        queue.Enqueue("1");
        for (int i = 0; i < N; i++)
        {
            string current = queue.Dequeue();
            result.Add(current);
            queue.Enqueue(current + "0");
            queue.Enqueue(current + "1");
        }

        return result;
    }

}
