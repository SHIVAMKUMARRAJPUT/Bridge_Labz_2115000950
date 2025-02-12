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
    static Node RemoveNode(Node head, int data){
        if (head == null) return null;
        if (head.Data == data)
            return head.Next; 
        Node temp = head;
        while (temp.Next != null && temp.Next.Data != data){
            temp = temp.Next;
        }

        if (temp.Next != null)
            temp.Next = temp.Next.Next; 
        return head;
    }

    static void Display(Node head){
        Node temp = head;
        while (temp != null){
            Console.Write(temp.Data + " -> ");
            temp = temp.Next;
        }
        Console.WriteLine("null");
    }

    static void Main(){
        Node head = new Node(10); 
        head = AddNode(head, 20);
        head = AddNode(head, 30);
        head = AddNode(head, 40);
        Console.WriteLine("Linked List:");
        Display(head);
        head = RemoveNode(head, 30);
        Console.WriteLine("After Removing 30:");
        Display(head);
    }
}
