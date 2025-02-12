using System;
class Node{
    public int Data;
    public Node Next;

    public Node(int data)
    {
        Data = data;
        Next = null;
    }
}

class Program
{
    static void Main()
    {
        // Creating nodes manually
        Node first = new Node(10);
        Node second = new Node(20);
        Node third = new Node(30);

        // Manually linking nodes
        first.Next = second;
        second.Next = third;
    }
}
