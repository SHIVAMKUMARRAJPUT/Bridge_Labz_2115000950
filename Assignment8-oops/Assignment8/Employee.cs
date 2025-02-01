using System;
public class Test1{
  public static void print(){
        Console.Write("Enter the Employee Id: ");
        int id = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the Salary: ");
        double salary = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the name: ");
        string name = Console.ReadLine();
        Employee emp1 = new Employee(name, id, salary);
        emp1.DisplayDetails();
    }



}
public class Employee{
    // Attributes
   public string Name;
    public int Id;
    public double Salary;
    // Constructor
    public Employee(string name, int id, double salary){
        Name = name;
        Id = id;
        Salary = salary;
    }

    // Method to display employee details
    public void DisplayDetails(){
        Console.WriteLine("Employee ID: " + Id);
        Console.WriteLine("Name: " + Name);
        Console.WriteLine("Salar  INR: " + Salary);
    }
   
  }




