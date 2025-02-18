using System;
class BubbleSort{
    public static void Print(){
       int[] arr = { 5, 1, 4, 2, 8 };

        for (int i = 0; i < arr.Length; i++)
        { bool swap =false;
            for (int j = 0; j < arr.Length-i-1; j++){
                if(arr[j]>arr[j+1]){
                    int temp=arr[j];
                    arr[j]=arr[j+1];
                    arr[j+1]=temp;
                    swap =true;
                }
                
            }
            if(!swap){
                break;
            }
            
        }
        foreach (var item in arr){
           Console.Write(item+" "); 
        }
    }
}