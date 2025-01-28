using System;

class UnitConverter{
    public const double KmToMilesFactor = 0.621371;
    public const double MilesToKmFactor = 1.60934;
    public const double MetersToFeetFactor = 3.28084;
    public const double FeetToMetersFactor = 0.3048;

    public static double ConvertKmToMiles(double km){
        return km * KmToMilesFactor;
    }
    public static double ConvertMilesToKm(double miles){
        return miles * MilesToKmFactor;
    }
    public static double ConvertMetersToFeet(double meters){
        return meters * MetersToFeetFactor;
    }
    public static double ConvertFeetToMeters(double feet){
        return feet * FeetToMetersFactor;
    }
}

class program_04{
    public static void convert(){
        Console.Write("Enter distance in kilometers: ");
        double km = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"{km} km = {UnitConverter.ConvertKmToMiles(km):F4} miles");
        
        Console.Write("Enter distance in miles: ");
        double miles =Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"{miles} miles = {UnitConverter.ConvertMilesToKm(miles):F4} km");
        
        Console.Write("Enter distance in meters: ");
        double meters = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"{meters} meters = {UnitConverter.ConvertMetersToFeet(meters):F4} feet");
        
        Console.Write("Enter distance in feet: ");
        double feet = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"{feet} feet = {UnitConverter.ConvertFeetToMeters(feet):F4} meters");
    }
}
