namespace TriangleClassifier.Tests
{
    [TestFixture]
    public class TriangleTests
    {
        // Tests covering equilateral triangles

        [Test]
        public void GetType_EquilateralTriangleWholeNumbers_ReturnsEquilateral()
        {
            double a = 3;
            double b = 3;
            double c = 3;

            Triangle triangle = new Triangle(a, b, c);

            TriangleType actualType = triangle.GetType();

            Assert.That(actualType, Is.EqualTo(TriangleType.Equilateral));
        }

        [Test]
        public void GetType_EquilateralTriangleDecimalNumbers_ReturnsEquilateral()
        {
            double a = 3.45;
            double b = 3.45;
            double c = 3.45;
            
            Triangle triangle = new Triangle(a, b, c);

            TriangleType actualType = triangle.GetType();

            Assert.That(actualType, Is.EqualTo(TriangleType.Equilateral));
        }
        
        [Test]
        public void GetType_EquilateralTriangleMixedNumbers_ReturnsEquilateral()
        {
            double a = 3.0;
            double b = 3;
            double c = 3;

            Triangle triangle = new Triangle(a, b, c);

            TriangleType actualType = triangle.GetType();

            Assert.That(actualType, Is.EqualTo(TriangleType.Equilateral));
        }

        // Tests covering isosceles triangles

        [Test]
        public void GetType_IsoscelesTriangleWholeNumbers_ReturnsIsosceles()
        {
            double a = 3;
            double b = 3;
            double c = 4;

            Triangle triangle = new Triangle(a, b, c);

            TriangleType actualType = triangle.GetType();

            Assert.That(actualType, Is.EqualTo(TriangleType.Isosceles));
        }

        [Test]
        public void GetType_IsoscelesTriangleDecimalNumbers_ReturnsIsosceles()
        {
            double a = 3.45;
            double b = 3.45;
            double c = 4.45;

            Triangle triangle = new Triangle(a, b, c);

            TriangleType actualType = triangle.GetType();

            Assert.That(actualType, Is.EqualTo(TriangleType.Isosceles));
        }

        [Test]
        public void GetType_IsoscelesTriangleWithMixedNumbers_ReturnsIsosceles()
        {
            double a = 3.45;
            double b = 3.45;
            double c = 4;

            Triangle triangle = new Triangle(a, b, c);

            TriangleType actualType = triangle.GetType();

            Assert.That(actualType, Is.EqualTo(TriangleType.Isosceles));
        }

        // Tests covering scalene triangles 

        [Test]
        public void GetType_ScaleneTriangleWholeNumbers_ReturnsScalene()
        {
            double a = 3;
            double b = 4;
            double c = 5;

            Triangle triangle = new Triangle(a, b, c);

            TriangleType actualType = triangle.GetType();

            Assert.That(actualType, Is.EqualTo(TriangleType.Scalene));
        }
        [Test]
        public void GetType_ScaleneTriangleDecimalNumbers_ReturnsScalene()
        {
            double a = 3.45;
            double b = 4.45;
            double c = 5.45;

            Triangle triangle = new Triangle(a, b, c);

            TriangleType actualType = triangle.GetType();

            Assert.That(actualType, Is.EqualTo(TriangleType.Scalene));
        }

        [Test]
        public void GetType_ScaleneTriangleMixedNumbers_ReturnsScalene()
        {
            double a = 3.45;
            double b = 4;
            double c = 5;
            Triangle triangle = new Triangle(a, b, c);

            TriangleType actualType = triangle.GetType();

            Assert.That(actualType, Is.EqualTo(TriangleType.Scalene));
        }

        // Tests covering invalid triangles

        [Test]
        public void GetType_InvalidTriangle_ReturnsInvalid()
        {
            double a = 1;
            double b = 1;
            double c = 10;
            Triangle triangle = new Triangle(a, b, c);

            TriangleType actualType = triangle.GetType();

            Assert.That(actualType, Is.EqualTo(TriangleType.Invalid));
        }

        [Test]
        public void GetType_TriangleWithNegativeLengths_ReturnsInvalid()
        {
            double a = -1;
            double b = 2;
            double c = 3;
            Triangle triangle = new Triangle(a, b, c);

            TriangleType actualType = triangle.GetType();

            Assert.That(actualType, Is.EqualTo(TriangleType.Invalid));
        }

        [Test]
        public void GetType_TriangleWithZeroLengthSides_ReturnsInvalid()
        {
            var triangle = new Triangle(0, 3, 4);

            var actualType = triangle.GetType();

            Assert.That(actualType, Is.EqualTo(TriangleType.Invalid));
        }

        // Boundary tests

        [Test]
        public void GetType_EquilateralTriangleWithSmallestPossibleSides_ReturnsEquilateral()
        {
            double x = double.Epsilon;

            Triangle triangle = new Triangle(x, x, x);

            TriangleType actualType = triangle.GetType();

            Assert.That(actualType, Is.EqualTo(TriangleType.Equilateral));
        }

        [Test]
        public void GetType_EquilateralTriangleWithLargestPossibleSides_ReturnsEquilateral()
        {
            double x = double.MaxValue;

            Triangle triangle = new Triangle(x, x, x);

            TriangleType actualType = triangle.GetType();

            Assert.That(actualType, Is.EqualTo(TriangleType.Equilateral));
        }


        [Test]
        public void GetType_BoundaryConditionTriangleNearEquilateral_ReturnsIsosceles()
        {
            var triangle = new Triangle(1, 1, 1.0000000001);

            var actualType = triangle.GetType();

            Assert.That(actualType, Is.EqualTo(TriangleType.Isosceles));
        }

        [Test]
        public void GetType_BoundaryConditionTriangleNearIsosceles_ReturnsScalene()
        {
            var triangle = new Triangle(3, 4, 4.0000000001);

            var actualType = triangle.GetType();

            Assert.That(actualType, Is.EqualTo(TriangleType.Scalene));
        }

    }
}
