using System;
using System.Collections.Generic;

class Test8{
    public static void Print(){
        HashSet<int> set1 = new HashSet<int> { 1, 2, 3 };
        HashSet<int> set2 = new HashSet<int> { 3, 4, 5 };

        HashSet<int> symmetricDifference = SymmetricDifference(set1, set2);

        Console.WriteLine("Symmetric Difference: {" + String.Join(", ", symmetricDifference) + "}");
    }

    static HashSet<int> SymmetricDifference(HashSet<int> set1, HashSet<int> set2){
        HashSet<int> result = new HashSet<int>();

        foreach (int item in set1){
            if (!set2.Contains(item))
                result.Add(item);
        }

        foreach (int item in set2){
            if (!set1.Contains(item))
                result.Add(item);
        }

        return result;
    }

}
