using System;
class prob_03
{
    public static void GradeChecker()
    {
        Console.WriteLine("Enter the Maths Marks:");
        int mathMarks = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the Physics Marks:");
        int physicsMarks = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the Chemistry Marks:");
        int chemistryMarks = Convert.ToInt32(Console.ReadLine());

        int totalMarks = mathMarks + physicsMarks + chemistryMarks;
        double averageMarks = (double)totalMarks / 3.0;

        if (averageMarks >= 80)
        {
            Console.WriteLine($"Average Marks: {averageMarks:F2}\nGrade: A");
        }
        else if (averageMarks >= 70)
        {
            Console.WriteLine($"Average Marks: {averageMarks:F2}\nGrade: B");
        }
        else if (averageMarks >= 60)
        {
            Console.WriteLine($"Average Marks: {averageMarks:F2}\nGrade: C");
        }
        else if (averageMarks >= 50)
        {
            Console.WriteLine($"Average Marks: {averageMarks:F2}\nGrade: D");
        }
        else if (averageMarks >= 40)
        {
            Console.WriteLine($"Average Marks: {averageMarks:F2}\nGrade: E");
        }
        else
        {
            Console.WriteLine($"Average Marks: {averageMarks:F2}\nGrade: R");
        }
    }

}
