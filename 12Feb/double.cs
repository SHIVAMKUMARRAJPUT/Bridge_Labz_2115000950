using System;

class Node{
    public int Data;
    public Node Prev;
    public Node Next;
    public Node(int data) {
        Data = data;
        Prev = null;
        Next = null;
    }
}
class Program{
    static void Main(){
        Node first = new Node(10);
        Node second = new Node(20);
        Node third = new Node(30);
        first.Next = second;
        second.Prev = first;
        second.Next = third;
        third.Prev = second;
        Console.WriteLine("Forward Traversal:");
        Node temp = first;
    }
}
