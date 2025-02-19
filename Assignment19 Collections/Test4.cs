using System;
using System.Collections.Generic;
class Test4{
    public static void Print() {
        List<int> numbers = new List<int> { 3, 1, 2, 2, 3, 4 };
        List<int> result = RemoveDuplicates(numbers);
        Console.WriteLine("List after removing duplicates: [" + string.Join(", ", result) + "]");
    }

    static List<int> RemoveDuplicates(List<int> list){
        HashSet<int> seen = new HashSet<int>();
        List<int> result = new List<int>();
        foreach (int number in list){
            if (!seen.Contains(number)) {
                result.Add(number);
                seen.Add(number);
            }
        }
        return result;
    }
}
