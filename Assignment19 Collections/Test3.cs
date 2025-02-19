using System;
using System.Collections.Generic;
class Test3{
    public static void Print(){
        List<int> numbers = new List<int> { 10, 20, 30, 40, 50 };
        int positions = 2;
        RotateList(numbers, positions);
        Console.WriteLine("Rotated List: [" + string.Join(", ", numbers) + "]");
    }

    static void RotateList(List<int> list, int positions) {
        int count = list.Count;
        positions = positions % count;
        List<int> rotated = new List<int>();
        for (int i = positions; i < count; i++){
            rotated.Add(list[i]);
        }

        for (int i = 0; i < positions; i++){
            rotated.Add(list[i]);
        }

        list.Clear();
        list.AddRange(rotated);
    }
}
