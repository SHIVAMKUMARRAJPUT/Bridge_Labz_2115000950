using System;

class Node1
{
    public int Data;
    public Node1 Next;

    public Node1(int data)
    {
        Data = data;
        Next = null;
    }
}

class MyStack1
{
    private Node1 top;

    public MyStack1()
    {
        top = null;
    }

    public void Push(int value)
    {
        Node1 newNode = new Node1(value);
        newNode.Next = top;
        top = newNode;
    }



    public void PrintStack(){
        Node1 temp = top;
        while (temp != null)
        {
            Console.Write(temp.Data + " ");
            temp = temp.Next;
        }
        Console.WriteLine();
    }
}

class Test2{
   public static void Print(){
        MyStack1 stack = new MyStack1();
        stack.Push(10);
        stack.Push(20);
        stack.Push(30);
        stack.PrintStack(); // Output: 30 20 10

    }
}
