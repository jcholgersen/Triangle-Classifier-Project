using System.Globalization;

namespace TriangleClassifier
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter the lengths of the sides of a triangle to classify its type (use '.' for decimals).");

            Console.Write("Length of side a: ");
            string? inputA = Console.ReadLine();
            double a = ParseDouble(inputA);

            Console.Write("Length of side b: ");
            string? inputB = Console.ReadLine();
            double b = ParseDouble(inputB);

            Console.Write("Length of side c: ");
            string? inputC = Console.ReadLine();
            double c = ParseDouble(inputC);

            Triangle t = new Triangle(a, b, c);

            Console.WriteLine($"The triangle was classified as: {t.GetType()}");
        }

        public static double ParseDouble(string? input)
        {
            if (!double.TryParse(input, new CultureInfo("en-GB"), out double value))
            {
                throw new ArgumentException($"Invalid argument. Side length must be numerical.");
            }

            return value;
        }

    }
}