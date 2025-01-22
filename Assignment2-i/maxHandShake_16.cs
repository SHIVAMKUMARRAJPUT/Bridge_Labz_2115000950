using System;

class maxHandshake_16{
    public static void fun(){
        // input for the number of students
        Console.Write("Enter the number of students: ");
        int numberOfStudents = Convert.ToInt32(Console.ReadLine());
        
        // the max handshakes
        int handshakes = (numberOfStudents * (numberOfStudents - 1)) / 2;
     
        Console.WriteLine($"The maximum number of handshakes among {numberOfStudents} students is {handshakes}.");
    }
}
