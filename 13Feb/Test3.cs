using System;

class Node2
{
    public int Data;
    public Node2 Next;

    public Node2(int data)
    {
        Data = data;
        Next = null;
    }
}

class MyStack2
{
    private Node2 top;

    public MyStack2()
    {
        top = null;
    }

    public void Push(int value)
    {
        Node2 newNode = new Node2(value);
        newNode.Next = top;
        top = newNode;
    }

    public int Pop()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Stack Underflow");
            return -1;
        }
        int value = top.Data;
        top = top.Next;
        return value;
    }

    public int Peek()
    {
        if (IsEmpty())
        {
            Console.WriteLine("Stack is empty");
            return -1;
        }
        return top.Data;
    }

    public bool IsEmpty()
    {
        return top == null;
    }

    public void PrintStack()
    {
        Node2 temp = top;
        while (temp != null)
        {
            Console.Write(temp.Data + " ");
            temp = temp.Next;
        }
        Console.WriteLine();
    }
}

class Test3
{
   public static void Print()
    {
        MyStack2 stack = new MyStack2();
        stack.Push(10);
        stack.Push(20);
        stack.Push(30);
        stack.PrintStack(); // Output: 30 20 10

        Console.WriteLine("Top element: " + stack.Peek()); // Output: 30
        Console.WriteLine("Popped: " + stack.Pop()); // Output: 30
        stack.PrintStack(); // Output: 20 10
    }
}
