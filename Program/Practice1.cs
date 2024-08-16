using System;
using System.Runtime.Intrinsics.X86;

namespace Program
{
    class PrimitiveDataTypesAndExpressions
    {
        static void Main(string[] args)
        {
            double weight;
            double height;

            Console.WriteLine("Welcome to the BMI Calculator");
            // Getting input from user
            Console.Write("Enter your weight in kilograms: ");
            weight = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter your height in meters: ");
            height = Convert.ToDouble(Console.ReadLine());

            // Calculate BMI
            double bmi = weight / (height * height);
            Console.WriteLine($"Your Body Mass Index (BMI) is: {bmi}");

            // Display BMI category
            string category = DetermineBMICategory(bmi);
            Console.WriteLine($"You are considered: {category}");
        }

        private static string DetermineBMICategory(double bmi)
        {
            if (bmi < 18.5)
            {
                return "Underweight";
            }
            else if (bmi >= 18.5 && bmi < 24.9)
            {
                return "Normal weight";
            }
            else if (bmi >= 25 && bmi < 29.9)
            {
                return "Overweight";
            }
            else
            {
                return "Obesity";
            }
        }
    }
}