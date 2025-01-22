using System;
class problem10{
    static void Main(){
        Console.Write("Enter the distance in kilometers: ");
        double km = Convert.ToDouble(Console.ReadLine());

        double mi = km * 0.621371;
        Console.WriteLine("Distance in miles: " + mi);
    }
    
}
