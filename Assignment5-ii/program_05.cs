using System;

class Converter1{
    public const double KmToMilesFactor = 0.621371;
    public const double MilesToKmFactor = 1.60934;
    public const double MetersToFeetFactor = 3.28084;
    public const double FeetToMetersFactor = 0.3048;
    public const double YardsToFeetFactor = 3.0;
    public const double FeetToYardsFactor = 0.333333;
    public const double MetersToInchesFactor = 39.3701;
    public const double InchesToMetersFactor = 0.0254;
    public const double InchesToCmFactor = 2.54;

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
    
    public static double ConvertYardsToFeet(double yards){
        return yards * YardsToFeetFactor;
    }
    
    public static double ConvertFeetToYards(double feet){
        return feet * FeetToYardsFactor;
    }
    
    public static double ConvertMetersToInches(double meters){
        return meters * MetersToInchesFactor;
    }
    
    public static double ConvertInchesToMeters(double inches){
        return inches * InchesToMetersFactor;
    }
    
    public static double ConvertInchesToCm(double inches){
        return inches * InchesToCmFactor;
    }
}

class program_05{
    public static void DistanceConvertor(){
        Console.Write("Enter a value in kilometers: ");
        double km = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"{km} km = {Converter1.ConvertKmToMiles(km):F4} miles");
        
        Console.Write("Enter a value in miles: ");
        double miles = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"{miles} miles = {Converter1.ConvertMilesToKm(miles):F4} km");
        
        Console.Write("Enter a value in meters: ");
        double meters = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"{meters} meters = {Converter1.ConvertMetersToFeet(meters):F4} feet");
        
        Console.Write("Enter a value in feet: ");
        double feet = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"{feet} feet = {Converter1.ConvertFeetToMeters(feet):F4} meters");
        
        Console.Write("Enter a value in yards: ");
        double yards = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"{yards} yards = {Converter1.ConvertYardsToFeet(yards):F4} feet");
        
        Console.Write("Enter a value in feet: ");
        feet = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"{feet} feet = {Converter1.ConvertFeetToYards(feet):F4} yards");
        
        Console.Write("Enter a value in meters: ");
        meters = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"{meters} meters = {Converter1.ConvertMetersToInches(meters):F4} inches");
        
        Console.Write("Enter a value in inches: ");
        double inches = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"{inches} inches = {Converter1.ConvertInchesToMeters(inches):F4} meters");
        
        Console.Write("Enter a value in inches: ");
        inches =Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"{inches} inches = {Converter1.ConvertInchesToCm(inches):F4} cm");
    }
}