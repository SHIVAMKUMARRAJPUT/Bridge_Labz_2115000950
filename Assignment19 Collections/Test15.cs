using System;
using System.Collections.Generic;

class Test15{
    public static void Print(Dictionary<string, int> inputMap){
        Dictionary<int, List<string>> invertedMap = new Dictionary<int, List<string>>();
        foreach (var entry in inputMap){
            if (!invertedMap.ContainsKey(entry.Value)){
                invertedMap[entry.Value] = new List<string>();
            }
            invertedMap[entry.Value].Add(entry.Key);
        }
        Console.WriteLine("Inverted Dictionary:");
        foreach (var entry in invertedMap){
            Console.Write($"\"{entry.Key}\": [");
            Console.Write(string.Join(", ", entry.Value));
            Console.WriteLine("]");
        }
    }

    public static void print()
    {
 
        Dictionary<string, int> inputMap = new Dictionary<string, int>
        {
            { "A", 1 },
            { "B", 2 },
            { "C", 1 }
        };

        Print(inputMap);
    }
}
