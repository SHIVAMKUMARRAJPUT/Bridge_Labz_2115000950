using System;
class prob_12
{
    public static void fun(){
        Console.Write("Enter weight in pounds: ");
        double weightInPounds = Convert.ToDouble(Console.ReadLine());
        double weightInKg = weightInPounds * 2.2;
        Console.WriteLine($"The weight of the person in pounds is :{weightInPounds} and in kg : {weightInKg}");
    }
}