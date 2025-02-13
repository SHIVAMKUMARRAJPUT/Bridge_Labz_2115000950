using System;

class Node4
{
    public int Data;
    public Node4 Next;

    public Node4(int data)
    {
        Data = data;
        Next = null;
    }
}

class MyQueue
{
    private Node4 front;
    private Node4 rear;

    public MyQueue()
    {
        front = rear = null;
    }

    public void Enqueue(int value)
    {
        Node4 newNode = new Node4(value);
        if (rear == null) 
        {
            front = rear = newNode;
            return;
        }
        rear.Next = newNode;
        rear = newNode;
    }
}


class Test4{
   public static void Print(){
        MyQueue queue = new MyQueue();
        queue.Enqueue(10);
        queue.Enqueue(20);
        queue.Enqueue(30);
       
    }
}
