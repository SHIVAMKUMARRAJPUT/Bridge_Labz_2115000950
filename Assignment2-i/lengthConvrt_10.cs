class lengthConvrt_10{
    public static void convert(){
        Console.Write("Enter your height in centimeters: ");
        double heightCm = Convert.ToDouble(Console.ReadLine());
        double totalInches = heightCm / 2.54;
        int feet = (int)(totalInches / 12);
        double inches = totalInches % 12;
        Console.WriteLine($"Your Height in cm is {heightCm:F`2} while in feet is {feet} and inches is {inches:F2}.");
    
    }



}