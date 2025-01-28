using System;
class BMICalculator{
    // Method to calculate BMI for each person
    public static void CalculateBMI(double[,] data){
        for (int i = 0; i < 10; i++){
            double weight = data[i, 0];
            double heightInCm = data[i, 1];
            double heightInM = heightInCm / 100; // Convert height from cm to meters
            
            // BMI formula: BMI = weight (kg) / height^2 (m^2)
            double bmi = weight / (heightInM * heightInM);
            data[i, 2] = bmi; // Store BMI in the third column of the array
        }
    }

    // Method to determine the BMI status
    public static string GetBMIStatus(double bmi){
        if (bmi < 18.5)
            return "Underweight";
        else if (bmi >= 18.5 && bmi < 24.9)
            return "Normal weight";
        else if (bmi >= 25 && bmi < 29.9)
            return "Overweight";
        else
            return "Obesity";
    }
}

class program_10{
    public static void BMI(){
        double[,] teamData = new double[10, 3];
        for (int i = 0; i < 10; i++){
            Console.Write($"Enter weight (kg) for person {i + 1}: ");
            teamData[i, 0] = Convert.ToDouble(Console.ReadLine());
            Console.Write($"Enter height (cm) for person {i + 1}: ");
            teamData[i, 1] = Convert.ToDouble(Console.ReadLine());
        }
        // Calculate BMI for each person
        BMICalculator.CalculateBMI(teamData);
        // Display the height, weight, BMI, and BMI status of each person
        Console.WriteLine("\nPerson | Weight (kg) | Height (cm) | BMI    | Status");
        Console.WriteLine("--------------------------------------------------------");

        for (int i = 0; i < 10; i++){
            double weight = teamData[i, 0];
            double height = teamData[i, 1];
            double bmi = teamData[i, 2];
            string status = BMICalculator.GetBMIStatus(bmi);

            Console.WriteLine($"{i + 1,6} | {weight,11} | {height,11} | {bmi,6:F2} | {status}");
        }
    }
}
