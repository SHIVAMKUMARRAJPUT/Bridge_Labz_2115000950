using System;
public class QueueUsingStacks{
    private int[] stack1;
    private int[] stack2;
    private int top1, top2;
    private int size;

    public QueueUsingStacks(int capacity){
        size = capacity;
        stack1 = new int[size];
        stack2 = new int[size];
        top1 = -1;
        top2 = -1;
    }
    public void Enqueue(int item){
        if (top1 == size - 1)
            throw new InvalidOperationException("Queue is full.");
        stack1[++top1] = item;
    }
    public int Dequeue(){
        if (top2 == -1){
            if (top1 == -1)
                throw new InvalidOperationException("Queue is empty.");
            while (top1 >= 0){
                stack2[++top2] = stack1[top1--];
            }
        }
        return stack2[top2--];
    }
    public bool IsEmpty(){
        return top1 == -1 && top2 == -1;
    }
    public int Count(){
        return (top1 + 1) + (top2 + 1);
    }
}
public class Test1{
    public static void Print(){
        QueueUsingStacks queue = new QueueUsingStacks(5);
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);
        Console.WriteLine(queue.Dequeue()); 
        Console.WriteLine(queue.Dequeue()); 
        queue.Enqueue(4);
        Console.WriteLine(queue.Dequeue()); 
        Console.WriteLine(queue.Dequeue()); 
    }
}
