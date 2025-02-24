using System;
using System.Reflection;

// Define a custom attribute
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
public class DescriptionAttribute : Attribute
{
    public string Description { get; }
    
    public DescriptionAttribute(string description)
    {
        Description = description;
    }
}

// Apply the custom attribute to a class and a method
[Description("This class represents a simple calculator.")]
public class Calculator
{
    [Description("Adds two numbers.")]
    public int Add(int a, int b)
    {
        return a + b;
    }

    [Description("Subtracts two numbers.")]
    public int Subtract(int a, int b)
    {
        return a - b;
    }
}

class Test2
{
    public static void Print()
    {
        // Get the type of the Calculator class
        Type calculatorType = typeof(Calculator);

        // Get and display the class attribute
        var classAttribute = (DescriptionAttribute)Attribute.GetCustomAttribute(calculatorType, typeof(DescriptionAttribute));
        if (classAttribute != null)
        {
            Console.WriteLine($"Class Description: {classAttribute.Description}");
        }

        // Get and display method attributes
        MethodInfo[] methods = calculatorType.GetMethods();
        foreach (var method in methods)
        {
            var methodAttribute = (DescriptionAttribute)Attribute.GetCustomAttribute(method, typeof(DescriptionAttribute));
            if (methodAttribute != null)
            {
                Console.WriteLine($"Method: {method.Name}, Description: {methodAttribute.Description}");
            }
        }

        // Create an instance of the Calculator class
        Calculator calculator = new Calculator();

        // Invoke methods using reflection
        int sum = (int)calculatorType.GetMethod("Add").Invoke(calculator, new object[] { 5, 3 });
        int difference = (int)calculatorType.GetMethod("Subtract").Invoke(calculator, new object[] { 5, 3 });

        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Difference: {difference}");
    }
}