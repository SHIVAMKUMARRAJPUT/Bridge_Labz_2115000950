using System;

class Convert2{
    public static double ConvertFahrenheitToCelsius(double fahrenheit){
        return (fahrenheit - 32) * 5 / 9;
    }
    public static double ConvertCelsiusToFahrenheit(double celsius){
        return (celsius * 9 / 5) + 32;
    }
    public static double ConvertPoundsToKilograms(double pounds){
        return pounds * 0.453592;
    }
    public static double ConvertKilogramsToPounds(double kilograms){
        return kilograms * 2.20462;
    }
    public static double ConvertGallonsToLiters(double gallons){
        return gallons * 3.78541;
    }
    public static double ConvertLitersToGallons(double liters){
        return liters * 0.264172;
    }
}

class program_06{
    public static void temperature(){
        Console.Write("Enter a value in Fahrenheit: ");
        double fahrenheit = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"{fahrenheit}°F = {Convert2.ConvertFahrenheitToCelsius(fahrenheit):F4}°C");

        Console.Write("Enter a value in Celsius: ");
        double celsius = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"{celsius}°C = {Convert2.ConvertCelsiusToFahrenheit(celsius):F4}°F");

        Console.Write("Enter a value in Pounds: ");
        double pounds = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"{pounds} lbs = {Convert2.ConvertPoundsToKilograms(pounds):F4} kg");

        Console.Write("Enter a value in Kilograms: ");
        double kilograms = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"{kilograms} kg = {Convert2.ConvertKilogramsToPounds(kilograms):F4} lbs");

        Console.Write("Enter a value in Gallons: ");
        double gallons = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"{gallons} gallons = {Convert2.ConvertGallonsToLiters(gallons):F4} liters");

        Console.Write("Enter a value in Liters: ");
        double liters = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"{liters} liters = {Convert2.ConvertLitersToGallons(liters):F4} gallons");
    }
}
