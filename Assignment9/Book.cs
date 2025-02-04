using System;

class Book{
    static string LibraryName = "Central Library GLA UNIVERSITY"; 
    public string Title;
    public string Author;
    readonly int ISBN;  
    public Book(string title, string author, int isbn){
        this.Title = title;
        this.Author = author;
        this.ISBN = isbn;
    }
    public static void DisplayLibraryName(){
        Console.WriteLine("Library Name: " + LibraryName);
    }
    public void DisplayDetails(){
        Console.WriteLine("Title: " + Title);
        Console.WriteLine("Author: " + Author);
        Console.WriteLine("ISBN: " + ISBN);
    }
}

class Test2{
    public static void Print(){
        int choice;


        while (true){
            Console.WriteLine("\n1. Add Book & DisplayDetails");
            Console.WriteLine("2. Exit");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice){
                case 1:
                    Console.Write("Enter Book Title: ");
                    string title = Console.ReadLine();
                    Console.Write("Enter Book Author: ");
                    string author = Console.ReadLine();
                    Console.Write("Enter Book ISBN: ");
                    int isbn = Convert.ToInt32(Console.ReadLine());
                    Book newBook = new Book(title, author, isbn);
                    if (newBook is Book){
                        Console.WriteLine("\n\n\nBook Details");
                        Console.WriteLine("===================");
                        Book.DisplayLibraryName();
                        newBook.DisplayDetails();
                    }else{
                        Console.WriteLine("Invalid Object");
                    }
                    break;

                case 2:
                    Console.WriteLine("Exiting Library System...");
                    return;

                default:
                    Console.WriteLine("Invalid");
                    break;
            }
        }
    }
}
