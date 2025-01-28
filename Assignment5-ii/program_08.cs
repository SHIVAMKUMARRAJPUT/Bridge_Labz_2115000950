using System;
class program_08{
    public static void TallAndYoungFriend(){
        // Arrays to store ages and heights of 3 friends
        int[] ages = new int[3];
        double[] heights = new double[3];

        // Input for ages and heights of Amar, Akbar, and Anthony
        Console.Write("Enter age of Amar: ");
        ages[0] = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter height of Amar (in meters): ");
        heights[0] = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter age of Akbar: ");
        ages[1] = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter height of Akbar (in meters): ");
        heights[1] = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter age of Anthony: ");
        ages[2] = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter height of Anthony (in meters): ");
        heights[2] = Convert.ToDouble(Console.ReadLine());

        // Find and display the youngest and tallest friends
        string youngest = FindYoungest(ages);
        string tallest = FindTallest(heights);

        Console.WriteLine($"The youngest friend is: {youngest}");
        Console.WriteLine($"The tallest friend is: {tallest}");
    }

  // Method to find the youngest friend
    public static string FindYoungest(int[] ages)
    {
        int youngestAge = ages[0];
        string youngestFriend = "Amar";
        
        // Check the youngest age
        for (int i = 1; i < ages.Length; i++)
        {
            if (ages[i] < youngestAge)
            {
                youngestAge = ages[i];
                youngestFriend = i == 1 ? "Akbar" : "Anthony"; // Update friend name based on index
            }
        }
        
        return youngestFriend;
    }

    // Method to find the tallest friend
    public static string FindTallest(double[] heights)
    {
        double tallestHeight = heights[0];
        string tallestFriend = "Amar";

        // Check the tallest height
        for (int i = 1; i < heights.Length; i++)
        {
            if (heights[i] > tallestHeight)
            {
                tallestHeight = heights[i];
                tallestFriend = i == 1 ? "Akbar" : "Anthony"; // Update friend name based on index
            }
        }
        
        return tallestFriend;
    }
}
