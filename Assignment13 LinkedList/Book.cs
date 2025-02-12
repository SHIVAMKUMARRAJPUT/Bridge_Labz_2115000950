using System;

class Book{
    public string Title;
    public string Author;
    public string Genre;
    public int BookID;
    public bool IsAvailable;
    public Book Prev;
    public Book Next;

    public Book(string title, string author, string genre, int bookID, bool isAvailable){
        Title = title;
        Author = author;
        Genre = genre;
        BookID = bookID;
        IsAvailable = isAvailable;
        Prev = null;
        Next = null;
    }
}

class Library{
    private Book head;
    private Book tail;
    private int count;

    public void AddBookAtBeginning(string title, string author, string genre, int bookID, bool isAvailable){
        Book newBook = new Book(title, author, genre, bookID, isAvailable);
        if (head == null){
            head = tail = newBook;
        } else {
            newBook.Next = head;
            head.Prev = newBook;
            head = newBook;
        }
        count++;
    }

    public void AddBookAtEnd(string title, string author, string genre, int bookID, bool isAvailable){
        Book newBook = new Book(title, author, genre, bookID, isAvailable);
        if (head == null){
            head = tail = newBook;
        } else {
            tail.Next = newBook;
            newBook.Prev = tail;
            tail = newBook;
        }
        count++;
    }

    public void RemoveBookByID(int bookID){
        Book temp = head;
        while (temp != null){
            if (temp.BookID == bookID){
                if (temp.Prev != null){
                    temp.Prev.Next = temp.Next;
                } else {
                    head = temp.Next;
                }
                if (temp.Next != null){
                    temp.Next.Prev = temp.Prev;
                } else {
                    tail = temp.Prev;
                }
                count--;
                return;
            }
            temp = temp.Next;
        }
        Console.WriteLine("Book not found");
    }

    public void SearchBook(string title = "", string author = ""){
        Book temp = head;
        while (temp != null){
            if (temp.Title == title || temp.Author == author){
                Console.WriteLine($"Title: {temp.Title}, \nAuthor: {temp.Author}, \nGenre: {temp.Genre}, \nBookID: {temp.BookID}, \nAvailable: {temp.IsAvailable}\n");
                return;
            }
            temp = temp.Next;
        }
        Console.WriteLine("Book not found");
    }

    public void UpdateAvailability(int bookID, bool isAvailable){
        Book temp = head;
        while (temp != null){
            if (temp.BookID == bookID){
                temp.IsAvailable = isAvailable;
                Console.WriteLine("Availability updated successfully");
                return;
            }
            temp = temp.Next;
        }
        Console.WriteLine("Book not found");
    }

    public void DisplayBooksForward(){
        Book temp = head;
        while (temp != null){
            Console.WriteLine($"Title: {temp.Title}, \nAuthor: {temp.Author}, \nGenre: {temp.Genre}, \nBookID: {temp.BookID}, \nAvailable: {temp.IsAvailable}\n");
            temp = temp.Next;
        }
    }

    public void DisplayBooksReverse(){
        Book temp = tail;
        while (temp != null){
            Console.WriteLine($"Title: {temp.Title}, \nAuthor: {temp.Author}, \nGenre: {temp.Genre}, \nBookID: {temp.BookID}, \nAvailable: {temp.IsAvailable}\n");
            temp = temp.Prev;
        }
    }

    public void CountBooks(){
        Console.WriteLine($"Total Books in Library: {count}");
    }
}

class Test5{
    public static void Print(){
        Library library = new Library();
        library.AddBookAtEnd("Java: The Complete Reference", "Herbert Schildt", "Programming", 143, true);
        library.AddBookAtEnd("C# in Depth", "Jon Skeet", "Programming", 123, true);
        library.AddBookAtBeginning("Theory of Automata", "KL Mishra", "Computer Science", 532, false);
        library.AddBookAtBeginning("Clean Code", "Robert Martin", "Software Development", 126, true);

        Console.WriteLine("===Library Books (Forward)===");
        library.DisplayBooksForward();

        Console.WriteLine("\n===Library Books (Reverse)===");
        library.DisplayBooksReverse();

        Console.WriteLine("\n===Searching for Book ID ===");
        library.SearchBook("", "Jon Skeet");

        Console.WriteLine("\n===Updating Availability for Book ID ===");
        library.UpdateAvailability(143, false);

        Console.WriteLine("\n===Removing Book ID===");
        library.RemoveBookByID(532);

        Console.WriteLine("\n===Final Library Books===");
        library.DisplayBooksForward();
        library.CountBooks();

    }
}