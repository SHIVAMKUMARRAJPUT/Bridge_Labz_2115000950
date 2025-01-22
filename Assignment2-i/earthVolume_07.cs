
   class earthVolume_07
   {
    
    public static void kmAndMiles()
    {
        // User input for radius
        Console.Write("Enter the radius of Earth in km: ");
        double radius_km = Convert.ToDouble(Console.ReadLine());

       
        double volume_km3 = (4.0 / 3.0) * Math.PI * Math.Pow(radius_km, 3);

        // 1 km^3 = 0.239913 miles^3
        double conversion_factor = 0.239913;
        double volume_miles3 = volume_km3 * conversion_factor;

     
        Console.WriteLine($"The volume of Earth in cubic kilometers is {volume_km3:F2} and cubic miles is {volume_miles3:F2}");
    }
   } 