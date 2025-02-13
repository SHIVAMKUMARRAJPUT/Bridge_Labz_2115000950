using System;

class Node5
{
    public int Data;
    public Node5 Next;

    public Node5(int data)
    {
        Data = data;
        Next = null;
    }
}

class MyQueue1
{
    private Node5 front;
    private Node5 rear;

    public MyQueue1()
    {
        front = rear = null;
    }

    public void Enqueue(int value)
    {
        Node5 newNode = new Node5(value);
        if (rear == null) 
        {
            front = rear = newNode;
            return;
        }
        rear.Next = newNode;
        rear = newNode;
    }

    public int Dequeue()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Queue Underflow");
            return -1;
        }
        int value = front.Data;
        front = front.Next;
        if (front == null) 
            rear = null; // Reset rear when queue is empty
        return value;
    }

    public int Peek()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Queue is empty");
            return -1;
        }
        return front.Data;
    }

    public bool IsEmpty()
    {
        return front == null;
    }

    public void PrintQueue()
    {
        Node5 temp = front;
        while (temp != null)
        {
            Console.Write(temp.Data + " ");
            temp = temp.Next;
        }
        Console.WriteLine();
    }
}

class Test5
{
    public static void Print()
    {
        MyQueue1 queue = new MyQueue1();
        queue.Enqueue(10);
        queue.Enqueue(20);
        queue.Enqueue(30);
        queue.PrintQueue(); // Output: 10 20 30

        Console.WriteLine("Front element: " + queue.Peek()); // Output: 10
        Console.WriteLine("Dequeued: " + queue.Dequeue()); // Output: 10
        queue.PrintQueue(); // Output: 20 30
    }
}
