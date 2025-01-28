using System;

class Season
{
    public static void Print()
    {
        Console.Write("Enter month: ");
        int month = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter day: ");
        int day = Convert.ToInt32(Console.ReadLine());

        bool isSpring = IsSpringSeason(month, day);

        if (isSpring)
            Console.WriteLine("It is Spring season.");
        else
            Console.WriteLine("It is not Spring season.");
    }

    public static bool IsSpringSeason(int month, int day)
    {
        if ((month == 3 && day >= 20) || (month == 4) || (month == 5) || (month == 6 && day <= 20))
            return true; // Spring season
        else
            return false; // Not Spring season
    }
}