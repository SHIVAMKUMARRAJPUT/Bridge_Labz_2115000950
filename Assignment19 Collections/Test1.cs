using System;
using System.Collections;
class Test1
{
    public static void Print()
    {
        ArrayList list = new ArrayList() { 1, 2, 3, 4, 5 };
        ReverseList(list);
        Console.WriteLine("Reversed ArrayList: {" + String.Join(", ", list.ToArray()) + "}");
    }

    static void ReverseList(ArrayList list)
    {
        int left = 0;
        int right = list.Count - 1;

        while (left < right)
        {
            object temp = list[left];
            list[left] = list[right];
            list[right] = temp;
            left++;
            right--;
        }
    }
}
