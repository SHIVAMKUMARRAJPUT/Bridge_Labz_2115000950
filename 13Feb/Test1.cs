using System;

class Node
{
    public int Data;
    public Node Next;

    public Node(int data)
    {
        Data = data;
        Next = null;
    }
}

class MyStack
{
    private Node top;

    public MyStack()
    {
        top = null;
    }

    public void Push(int value)
    {
        Node newNode = new Node(value);
        newNode.Next = top;
        top = newNode;
    }

}

class Test1{
   public static void Print(){
        MyStack stack = new MyStack();
        stack.Push(10);
        stack.Push(20);
        stack.Push(30);
       
    }
}
