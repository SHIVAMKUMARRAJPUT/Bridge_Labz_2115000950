using System;

class program_11{
    // Method to calculate the roots of a quadratic equation

    public static void root(){
        // Taking input for coefficients a, b, and c
        Console.Write("Enter coefficient a: ");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter coefficient b: ");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter coefficient c: ");
        double c = Convert.ToDouble(Console.ReadLine());

        // Finding the roots
        double[] roots = FindRoots(a, b, c);

        // Displaying the roots
        if (roots.Length == 2)
        {
            Console.WriteLine($"The roots of the equation are: {roots[0]} and {roots[1]}");
        }
        else if (roots.Length == 1)
        {
            Console.WriteLine($"The root of the equation is: {roots[0]}");
        }
    }
    public static double[] FindRoots(double a, double b, double c){
        // Calculate delta (discriminant)
        double delta = Math.Pow(b, 2) - 4 * a * c;
        double[] roots = new double[0]; // Initialize an empty array for roots

        // If delta is positive, two real roots exist
        if (delta > 0){
            double root1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double root2 = (-b - Math.Sqrt(delta)) / (2 * a);
            roots = new double[] { root1, root2 };
        }// If delta is zero, one real root exists
        else if (delta == 0){
            double root = -b / (2 * a);
            roots = new double[] { root };
        }// If delta is negative, there are no real roots
        else{
            Console.WriteLine("No real roots exist.");
        }

        return roots;
    }
}
