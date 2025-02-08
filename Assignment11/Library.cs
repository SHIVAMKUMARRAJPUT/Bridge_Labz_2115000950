using System;
class Test4 {
    public static void Print() {
        Author book1 = new Author("The Mahabharata ", 1500, "Maharishi Ved Vyasa", "The Kurukshetra war between the Pandav and Kaurava");
        Author book2 = new Author("Ranayan", 5000, "Valmiki", "Life of Prabhu Shree Ram");
        book1.DisplayInfo();
        Console.WriteLine(); 
        book2.DisplayInfo();
    }
}

// Superclass: Book
class Book {
    public string Title;
    public int PublicationYear ;

    // Constructor
    public Book(string title, int publicationYear) {
        Title = title;
        PublicationYear = publicationYear;
    }

    // Virtual method 
        public virtual void DisplayInfo() {
        Console.WriteLine($"Book Title: {Title}");
        Console.WriteLine($"Publication Year: {PublicationYear}");
    }
}

// Subclass Author 
class Author : Book {
    public string Name ;
    public string Bio ;
    // Constructor
    public Author(string title, int publicationYear, string name, string bio) 
        : base(title, publicationYear) {
        Name = name;
        Bio = bio;
    }

    // Overriding 
    public override void DisplayInfo() {
        base.DisplayInfo();
        Console.WriteLine($"Author: {Name}");
        Console.WriteLine($"Bio: {Bio}");
    }
}

