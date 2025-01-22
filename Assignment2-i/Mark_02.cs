using System;
class Mark_02
{
    
   public static void avg()    {
        int maths = 94;
        int physics = 95;
        int chemistry = 96;
        int total = maths + physics + chemistry;
        double average = total / 3.0;
        Console.WriteLine($"Sam's average mark in PCM is {average }");
    }
}