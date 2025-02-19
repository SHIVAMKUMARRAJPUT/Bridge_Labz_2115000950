using System;
using System.Collections.Generic;

class Test10{
    public static void Print(){
        HashSet<int> subset = new HashSet<int> { 2, 3 };
        HashSet<int> superset = new HashSet<int> { 1, 2, 3, 4 };
        bool isSubset = IsSubset(subset, superset);
        Console.WriteLine(isSubset); 
    }

    static bool IsSubset(HashSet<int> subset, HashSet<int> superset){
        foreach (int item in subset){
            if (!superset.Contains(item))
                return false;
        }
        return true;
    }

}
