using System;

class HandshakeCalculator
{
    public static void Print()
    {
        Console.Write("Enter number of students: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int handshakes = (n * (n - 1)) / 2;
        Console.WriteLine("Maximum number of handshakes: " + handshakes);
    }
}
