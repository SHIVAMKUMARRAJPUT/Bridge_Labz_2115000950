using System;

class map{
    private const int Size = 1000;  
    private int[] keys;
    private bool[] occupied;

    public map(){
        keys = new int[Size];
        occupied = new bool[Size];
    }

    private int GetBucketIndex(int key){
        return Math.Abs(key) % Size;
    }

    public void Put(int key){
        int index = GetBucketIndex(key);
        
        while (occupied[index]){
            if (keys[index] == key)
                return;  
            index = (index + 1) % Size;
        }

        keys[index] = key;
        occupied[index] = true;
    }

    public bool Contains(int key){
        int index = GetBucketIndex(key);

        while (occupied[index]){
            if (keys[index] == key)
                return true;

            index = (index + 1) % Size;
        }
        return false;
    }
}

class PairWithGivenSum{
    public bool HasPairWithSum(int[] nums, int target){
        map map = new map();

        for (int i = 0; i < nums.Length; i++){
            int complement = target - nums[i];

            if (map.Contains(complement)){
                return true;
            }

            map.Put(nums[i]);
        }

        return false;
    }
}

class Test7{
    public static void Print(){
        PairWithGivenSum finder = new PairWithGivenSum();
        int[] nums = { 10, 15, 3, 7 };
        int target = 17;
        Console.WriteLine(finder.HasPairWithSum(nums, target));  
    }
}
