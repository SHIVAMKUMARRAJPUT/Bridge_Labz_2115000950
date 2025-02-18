using System;
using System.Runtime.InteropServices;
class SelectionSort
{
    public static void Print(){
        int []arr={9,8,7,6,5,4,3,2,1};
        for(int i=0;i<arr.Length;i++){
            int key=i;
            for(int j=i+1;j<arr.Length;j++){
                if(arr[j]<arr[i]){
                    key=j;
                }
            }
            int temp=arr[i];
            arr[i]=arr[key];
            arr[key]=temp;
        }
        foreach (var item in arr)
        {
           Console.Write(item+" "); 
        }
    }
}