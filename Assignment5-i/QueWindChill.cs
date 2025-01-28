using System;

class QueWindChill
{
    public static void Print()
    {
        Console.Write("Enter temperature (°F): ");
        double temperature = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter wind speed (mph): ");
        double windSpeed = Convert.ToDouble(Console.ReadLine());

        double windChill = CalculateWindChill(temperature, windSpeed);
        Console.WriteLine($"The wind chill is: {windChill:F2}°F");
    }

    public static double CalculateWindChill(double temperature, double windSpeed)
    {
        double windChill = 35.74 + 0.6215 * temperature + (0.4275 * temperature - 35.75) * Math.Pow(windSpeed, 0.16);
        return windChill;
    }
}