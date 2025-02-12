using System;
class Node{
    public int Data;
    public Node Next;
    public Node(int data){
        Data = data;
        Next = null;
    }
}

class Program{
    static void Main(){
        Node first = new Node(10);
        Node second = new Node(20);
        Node third = new Node(30);
        first.Next = second;
        second.Next = third;
        Node temp = first;
        while (temp != null){
            Console.Write(temp.Data + " -> ");
            temp = temp.Next;
        }
        Console.WriteLine("null");
    }
}
