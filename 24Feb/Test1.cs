using System;
using System.Reflection;

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public void Greet()
    {
        Console.WriteLine($"Hello, my name is {Name} and I am {Age} years old.");
    }
}

class Test1
{
    public static void Print()
    {
        // Create an instance of the Person class
        Person person = new Person { Name = "Shivam", Age = 21 };

        // Get the type of the Person class
        Type personType = typeof(Person);

        // Display the class name
        Console.WriteLine("Class Name: " + personType.Name);

        // Display properties
        Console.WriteLine("Properties:");
        PropertyInfo[] properties = personType.GetProperties();
        foreach (var property in properties)
        {
            Console.WriteLine($"- {property.Name} (Type: {property.PropertyType})");
        }

        // Display methods
        Console.WriteLine("Methods:");
        MethodInfo[] methods = personType.GetMethods();
        foreach (var method in methods)
        {
            Console.WriteLine($"- {method.Name}");
        }

        // Invoke the Greet method using reflection
        MethodInfo greetMethod = personType.GetMethod("Greet");
        greetMethod.Invoke(person, null);
    }
}