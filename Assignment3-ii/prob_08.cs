using System;
class prob_08{

 public static void tallestHeight()
    {
        Console.Write("Enter age of Amar: ");
        int amarAge = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter height of Amar (in cm): ");
        double amarHeight = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter age of Akbar: ");
        int akbarAge = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter height of Akbar (in cm): ");
        double akbarHeight = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter age of Anthony: ");
        int anthonyAge = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter height of Anthony (in cm): ");
        double anthonyHeight = Convert.ToDouble(Console.ReadLine());
        int youngestAge = amarAge;
        string youngestFriend = "Amar";
        if (akbarAge < youngestAge){
            youngestAge = akbarAge;
            youngestFriend = "Akbar";
        }
        if (anthonyAge < youngestAge){
            youngestAge = anthonyAge;
            youngestFriend = "Anthony";
        }
        double tallestHeight = amarHeight;
        string tallestFriend = "Amar";

        if (akbarHeight > tallestHeight){
            tallestHeight = akbarHeight;
            tallestFriend = "Akbar";
        }
        if (anthonyHeight > tallestHeight){
            tallestHeight = anthonyHeight;
            tallestFriend = "Anthony";
        }
        Console.WriteLine($"The youngest friend is: {youngestFriend} with age {youngestAge}");
        Console.WriteLine($"The tallest friend is: {tallestFriend} with height {tallestHeight} cm");
    }

}