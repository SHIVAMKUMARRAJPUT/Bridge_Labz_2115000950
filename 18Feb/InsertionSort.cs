using System;
class InsertionSort
{
    public static void Print(){
        int []arr={5,1,41,7,2,11,9,86,21,42};
        for(int i=0;i<arr.Length;i++){
            int key=arr[i];
            int j=i-1;
            while(j>=0 && arr[j]>key){
                arr[j+1]=arr[j];
                j--;
            }
            arr[j+1]=key;
        }
        foreach (var item in arr)
        {
            Console.Write(item+" ");
        }
    }
}