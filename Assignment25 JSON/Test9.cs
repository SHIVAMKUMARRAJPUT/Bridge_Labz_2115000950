using System;
using System.Collections.Generic;
using Newtonsoft.Json;

class Test9{
    public static void Print(){
        // List of Employee objects
        List<Employee> employees = new List<Employee>
        {
            new Employee { Name = "Shivam Kumar Rajput", Age = 25, Position = "Software Engineer" },
            new Employee { Name = "Pramendra Pratap Singh", Age = 30, Position = "Project Manager" },
            new Employee { Name = "Ashish Verma", Age = 28, Position = "Data Analyst" }
        };

        // Convert list to JSON array
        string jsonArray = JsonConvert.SerializeObject(employees, Formatting.Indented);
        Console.WriteLine("JSON Array:\n" + jsonArray);
    }
}

// Employee class
class Employee{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Position { get; set; }
}
