using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

class Test7
{
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

        // Filter records where Age > 25
        var filteredRecords = jsonArray.Where(obj => (int)obj["Age"] > 25);

        // Convert filtered records back to JSON
        string filteredJson = JsonConvert.SerializeObject(filteredRecords, Formatting.Indented);
        Console.WriteLine("Filtered JSON:\n" + filteredJson);
    }
}
