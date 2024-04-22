namespace TriangleClassifier
{
    public enum TriangleType
    {
        // If all sides are equal in length (ligesidet)
        Equilateral, 
        // If two sides are equal in length (ligebenet)
        Isosceles,
        // If all sides have different lengths (uligesidet)
        Scalene, 
        // If triangle equality is not satisfied
        Invalid
    }

    public class Triangle(double a, double b, double c)
    {
        public new TriangleType GetType()
        {
            if (!IsValidTriangle())
            {
                return TriangleType.Invalid;
            }
            if (a == b && b == c)
            {
                return TriangleType.Equilateral;
            }
            else if (a == b || a == c || b == c)
            {
                return TriangleType.Isosceles;
            }
            else
            {
                return TriangleType.Scalene;
            }
        }

        public bool IsValidTriangle()
        {   // Checking for triangle inequility  a + b ≥ c
            return a + b > c && a + c > b && b + c > a;
        }
    }


}
