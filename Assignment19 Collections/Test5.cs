using System;
using System.Collections.Generic;

class Test5{
    public static void Print() {
        LinkedList<string> list = new LinkedList<string>(new string[] { "A", "B", "C", "D", "E" });
        int N = 2;
        string result = FindNthFromEnd(list, N);
        Console.WriteLine($"The {N}th element from the end is: {result}");
    }

    static string FindNthFromEnd(LinkedList<string> list, int N) {
        LinkedListNode<string> first = list.First;
        LinkedListNode<string> second = list.First;

        for (int i = 0; i < N; i++)
        {
            if (second == null)
            {
                return null; 
            }
            second = second.Next;
        }

        while (second != null)
        {
            first = first.Next;
            second = second.Next;
        }

        return first.Value;
    }
}
