using System;
class Bsearch{
    public static void Search()
    {
        int []arr={1,2,3,4,5,6,7,8,9,10,12,14,15,16,17,18};
        int st=0;
        int end=arr.Length-1;
        int target=10;
        while(st<end){
            int mid=st + (end-st)/2;
            if(arr[mid]==target){
                Console.WriteLine("Element present on index :"+mid);
                return;
            }else if(arr[mid]<target){
                st=mid+1;
            }else{
                end=mid-1;
            }
        }
    }
}