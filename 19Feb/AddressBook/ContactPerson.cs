using System;
using System.Collections.Generic;
using System.Linq;

namespace AddressBook
{
    class ContactPerson
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public long Phone { get; set; }
        public string Email { get; set; }
    }

    interface IContact
    {
        void Add(ContactPerson person);
        void Remove(int id);
        void Display();
        void Update(int id, ContactPerson person);
    }

    class ContactManager : IContact
    {
        private List<ContactPerson> contacts = new List<ContactPerson>();

        public void Add(ContactPerson person)

        {
              foreach (var person1 in contacts){
               if(person1.Email==person.Email){
                Console.WriteLine("ENTER NEW Email");
                person.Email=Console.ReadLine();
                break;
               }
               
            }
            contacts.Add(person);
            Console.WriteLine("Contact added successfully.");
        }

        public void Remove(int id)
        {
            ContactPerson person = null;
            foreach (var p in contacts)
            {
                if (p.Id == id)
                {
                    person = p;
                    break; 
                }
            }

            if (person != null)
            {
                contacts.Remove(person);
                Console.WriteLine("Contact removed successfully.");
            }
            else
            {
                Console.WriteLine("Contact not found.");
            }
        }

        public void Display()
        {
            contacts.Sort(c.Name.Length=>  );
            // if (contacts.Count == 0){
            //     Console.WriteLine("No contacts available.");
            //     return;
            // }
            
            // String []arr=new string[contacts.Count];
            // List<ContactPerson> li=new List<ContactPerson>();
            // List<ContactPerson> li1=li;

            // int i=0;
            // foreach (var person in contacts){
            //     arr[i++]=person.Name;
            //     li.Add(person);
            //     Console.WriteLine($"ID: {person.Id}, Name: {person.Name}, Phone: {person.Phone}, Email: {person.Email}");
            // }
          
            

        }
        public static List<ContactPerson> Sort(List<ContactPerson> li){
         int []arr=new int [li.Count];
         int i=0;
        foreach(var item in li){
            arr[i++]=item.Id;
         }
       
        for(int j=0;j<arr.Length;j++){
            for(int k=0;k<arr.Length-1-j;k++){
                if(arr[k]<arr[k+1]){
                    int temp=arr[k];
                    arr[k]=arr[k+1];
                    arr[k+1]=temp;
                }
            }
        }
        foreach(var item in arr){
            foreach (var contact in li){
                if (contact.Id == item){
                    Console.WriteLine(li)
                    
                }
            }
        }
      
        return li;
        }

        public void Update(int id, ContactPerson person)
        {
            ContactPerson existing = null;
            foreach (var contact in contacts)
            {
                if (contact.Id == id)
                {
                    existing = contact;
                    break; 
                }
            }

            if (existing != null)
            {
                existing.Name = person.Name;
                existing.Email = person.Email;
                existing.Phone = person.Phone;
                Console.WriteLine("Contact updated successfully.");
            }
            else
            {
                Console.WriteLine("Contact not found.");
            }
        }
    }
}
