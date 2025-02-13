using System;

class MyMap
{
    private const int Size = 1000; 
    private int[] keys;
    private int[] values;
    private bool[] occupied;

    public MyMap()
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
        
        while (occupied[index]) 
        {
            if (keys[index] == key)
            {
                values[index] = value; 
                return;
            }
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
            {
                return values[index];
            }
            index = (index + 1) % Size;
        }
        
        throw new Exception("Key not found.");
    }

    public bool ContainsKey(int key)
    {
        int index = GetBucketIndex(key);

        while (occupied[index])
        {
            if (keys[index] == key)
            {
                return true;
            }
            index = (index + 1) % Size;
        }
        return false;
    }
}

class TwoSumFinder
{
    public int[] FindTwoSum(int[] nums, int target)
    {
        MyMap map = new MyMap();

        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];

            if (map.ContainsKey(complement)) {
                return new int[] { map.Get(complement), i };
            }

            map.Put(nums[i], i);
        }

        return new int[] { -1, -1 }; 
    }
}

class Test10{
    public static void Print(){
        TwoSumFinder finder = new TwoSumFinder();
        int[] nums = { 2, 7, 11, 15 };
        int target = 9;
        int[] result = finder.FindTwoSum(nums, target);

        Console.WriteLine($"[{result[0]}, {result[1]}]");
    }
}