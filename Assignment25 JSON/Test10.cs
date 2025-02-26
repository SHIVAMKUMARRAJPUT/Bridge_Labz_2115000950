using System;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

class Test10{
    public static void Print()
    {
        string json = @"[
            { 'Name': 'Shivam Kumar Rajput', 'Age': 25, 'Email': 'shivam@example.com' },
            { 'Name': 'Rahul Sharma', 'Age': 30, 'Email': 'rahul@example.com' },
            { 'Name': 'Amit Verma', 'Age': 28, 'Email': 'amit@example.com' },
            { 'Name': 'John Doe', 'Age': 24, 'Email': 'john@example.com' }
        ]";

        // Parse JSON array
        JArray jsonArray = JArray.Parse(json);

        // Filter users older than 25
        var filteredUsers = jsonArray.Where(user => (int)user["Age"] > 25);

        // Convert filtered users back to JSON
        string filteredJson = JsonConvert.SerializeObject(filteredUsers, Formatting.Indented);
        Console.WriteLine("Filtered JSON (Users Age > 25):\n" + filteredJson);
    }
}
