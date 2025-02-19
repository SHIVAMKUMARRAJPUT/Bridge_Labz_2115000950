using System;
using System.Collections.Generic;
class Test9{
    public static void Print(){
        HashSet<int> set = new HashSet<int> { 5, 3, 9, 1 };
        List<int> sortedList = ConvertToSortedList(set);
        Console.WriteLine("Sorted List: [" + String.Join(", ", sortedList) + "]");
    }
    static List<int> ConvertToSortedList(HashSet<int> set){
        List<int> result = new List<int>(set);
        for (int i = 0; i < result.Count - 1; i++)  {
            for (int j = 0; j < result.Count - i - 1; j++)    {
                if (result[j] > result[j + 1]) {
                    int temp = result[j];
                    result[j] = result[j + 1];
                    result[j + 1] = temp;
                }
            }
        }

        return result;
    }

}
