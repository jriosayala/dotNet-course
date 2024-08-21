namespace Program;

public class BmiCalculator(double weight, double height)
{
    public double Weight { get; set; } = weight;
    public double Height { get; set; } = height;

    public double CalculateBMI()
    {
        return Weight / (Height * Height);
    }

    public string DetermineBMICategory()
    {
        double bmi = CalculateBMI();
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