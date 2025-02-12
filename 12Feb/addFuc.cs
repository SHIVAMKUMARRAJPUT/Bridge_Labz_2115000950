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
    static Node AddNode(Node head, int data){
        Node newNode = new Node(data);
        
        if (head == null)
            return newNode; 
        
        Node temp = head;
        while (temp.Next != null){
            temp = temp.Next;
        }
        temp.Next = newNode; 
        return head;
    }
    static void Main(){
        Node head = new Node(10); 
        head = AddNode(head, 20);
        head = AddNode(head, 30);
        head = AddNode(head, 40);
        // Display the linked list
        Node temp = head;
        while (temp != null){
            Console.Write(temp.Data + " -> ");
            temp = temp.Next;
        }
        Console.WriteLine("null");
    }
}
