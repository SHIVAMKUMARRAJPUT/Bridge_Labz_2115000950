using System;
class Search
{
    public static void Linear(){
        int[]arr={1,2,3,4,5,1,3,9,87,8,76,54,2,65};
        int target=9;
        for(int i=0;i<arr.Length;i++){
            if(target==arr[i]){
                Console.WriteLine("Element is present on index: "+i);
                return;
            }
        }
        Console.WriteLine("Element is not present in the Array");
    }
}