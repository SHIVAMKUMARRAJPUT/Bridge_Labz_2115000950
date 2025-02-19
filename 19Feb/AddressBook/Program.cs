using System;
using AddressBook;

class Program{
    static void Main(){
        ContactManager addressBook = new ContactManager();

        addressBook.Add(new ContactPerson { Id = 1, Name = "SKRsd", Email = "SKR@gmail.com", Phone = 1234567890 });
        addressBook.Add(new ContactPerson { Id = 2, Name = "JKdR", Email = "JKR@gmail.com", Phone = 9876543210 });
        addressBook.Add(new ContactPerson { Id = 3, Name = "jkd", Email = "JKR@gmail.com", Phone = 9876543210 });
        addressBook.Display();

        addressBook.Update(1, new ContactPerson { Id = 1, Name = "SHIVAM", Email = "SHIVAM@gmail.com", Phone = 1112223333 });
        addressBook.Display();
        Console.WriteLine("\n");
        addressBook.Remove(2);
        addressBook.Display();
    }
}
