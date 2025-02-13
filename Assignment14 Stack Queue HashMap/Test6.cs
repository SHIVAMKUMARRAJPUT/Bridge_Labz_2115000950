using System;

class hMap
{
    private const int Size = 1000;
    private int[] keys;
    private int[] values;
    private bool[] occupied;

    public hMap()
    {
        keys = new int[Size];
        values = new int[Size];
        occupied = new bool[Size];
    }

    private int GetBucketIndex(int key)
    {
        return Math.Abs(key) % Size;
    }

    public void Put(int key, int value)
    {
        int index = GetBucketIndex(key);
        while (occupied[index] && keys[index] != key)
        {
            index = (index + 1) % Size;
        }
        keys[index] = key;
        values[index] = value;
        occupied[index] = true;
    }

    public int Get(int key)
    {
        int index = GetBucketIndex(key);
        while (occupied[index])
        {
            if (keys[index] == key)
                return values[index];
            index = (index + 1) % Size;
        }
        return -1; // Key not found
    }

    public bool ContainsKey(int key)
    {
        int index = GetBucketIndex(key);
        while (occupied[index])
        {
            if (keys[index] == key)
                return true;
            index = (index + 1) % Size;
        }
        return false;
    }
}

class ZeroSumSubarrays
{
    public static void FindAllZeroSumSubarrays(int[] arr)
    {
        int n = arr.Length;
        hMap map = new hMap();
        int sum = 0;

        Console.WriteLine("Zero-sum subarrays:");

        for (int i = 0; i < n; i++)
        {
            sum += arr[i];

            if (sum == 0)
            {
                Console.WriteLine($"Subarray found: (0, {i})");
            }

            if (map.ContainsKey(sum))
            {
                int start = map.Get(sum);
                Console.WriteLine($"Subarray found: ({start + 1}, {i})");
            }
            else
            {
                map.Put(sum, i);
            }
        }
    }
}

class Test6{
   public static void Print(){
        int[] arr = {3, 4, -7, 3, 1, 3, 1, -4, -2, -2};
        ZeroSumSubarrays.FindAllZeroSumSubarrays(arr);
    }
}
