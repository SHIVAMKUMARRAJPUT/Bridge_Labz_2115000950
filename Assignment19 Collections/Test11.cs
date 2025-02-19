using System;
using System.Collections.Generic;

class Test11{
    public static void Print(){
        Queue<int> queue = new Queue<int>();
        queue.Enqueue(10);
        queue.Enqueue(20);
        queue.Enqueue(30);
        Queue<int> reversedQueue = ReverseQueue(queue);
        Console.WriteLine("Reversed Queue: [" + String.Join(", ", reversedQueue) + "]");
    }

    static Queue<int> ReverseQueue(Queue<int> queue){
        Stack<int> stack = new Stack<int>();
        while (queue.Count > 0){
            stack.Push(queue.Dequeue());
        }
        while (stack.Count > 0){
            queue.Enqueue(stack.Pop());
        }

        return queue;
    }

}
