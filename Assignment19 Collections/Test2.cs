using System;
using System.Collections.Generic;
class Test2{
    public static void Print(){
        List<string> items = new List<string> { "apple", "banana", "apple", "orange" };
        Dictionary<string, int> frequency = CountFrequency(items);

        foreach (var kvp in frequency){
            Console.WriteLine($"\"{kvp.Key}\": {kvp.Value}");
        }
    }

    static Dictionary<string, int> CountFrequency(List<string> items){
        Dictionary<string, int> frequency = new Dictionary<string, int>();

        foreach (string item in items){
            if (frequency.ContainsKey(item)){
                frequency[item]++;
            } else {
                frequency[item] = 1;
            }
        }

        return frequency;
    }
}
