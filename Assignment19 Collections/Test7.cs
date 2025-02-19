using System;
using System.Collections.Generic;

class Test7{
    public static void Print(){
        HashSet<int> set1 = new HashSet<int> { 1, 2, 3 };
        HashSet<int> set2 = new HashSet<int> { 3, 4, 5 };
        HashSet<int> unionSet = Union(set1, set2);
        HashSet<int> intersectionSet = Intersection(set1, set2);
        Console.WriteLine("Union: {" + String.Join(", ", unionSet) + "}");
        Console.WriteLine("Intersection: {" + String.Join(", ", intersectionSet) + "}");
    }

    static HashSet<int> Union(HashSet<int> set1, HashSet<int> set2){
        HashSet<int> result = new HashSet<int>(set1);
        foreach (int item in set2){
            result.Add(item);
        }
        return result;
    }

    static HashSet<int> Intersection(HashSet<int> set1, HashSet<int> set2){
        HashSet<int> result = new HashSet<int>();
        foreach (int item in set1){
            if (set2.Contains(item)){
                result.Add(item);
            }
        }
        return result;
    }

}
