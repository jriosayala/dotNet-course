using System;

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
            Console.WriteLine($"Your Body Mass Index (BMI) is: {weight / (height * height):F2}");
        }
    }
}