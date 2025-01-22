using System;
class prob_06{

    public static void fun(){
        //  input from the user
        Console.Write("Enter salary (INR): ");
        double salary = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter bonus (INR): ");
        double bonus = Convert.ToDouble(Console.ReadLine());
        double totalIncome = salary + bonus;
        Console.WriteLine($"The salary is INR {salary} and bonus is INR {bonus}. Hence, Total Income is INR {totalIncome}.");
    }
}
