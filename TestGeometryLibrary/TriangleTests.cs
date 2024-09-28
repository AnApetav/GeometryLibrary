using GeometryLibrary;

namespace TestGeometryLibrary
{
    [TestFixture]
    public class TriangleTests
    {
        [Test]
        [Category("ConstructorValidation")]
        public void Constructor_WithValidSides_CreatesInstance()
        {
            // Arrange
            double sideA = 3;
            double sideB = 4;
            double sideC = 5;

            // Act
            var triangle = new Triangle(sideA, sideB, sideC);

            // Assert
            Assert.IsNotNull(triangle);
            Assert.That(triangle.SideA, Is.EqualTo(sideA));
            Assert.That(triangle.SideB, Is.EqualTo(sideB));
            Assert.That(triangle.SideC, Is.EqualTo(sideC));
        }
        

        [Test]
        [Category("AreaCalculation")]
        [TestCase(3, 4, 5, ExpectedResult = 6)]
        [TestCase(5, 12, 13, ExpectedResult = 30)]
        [TestCase(7, 24, 25, ExpectedResult = 84)]
        [TestCase(10, 10, 10, ExpectedResult = 43.30127018922193)] 
        public double CalculateArea_WithValidSides_ReturnsCorrectArea(double sideA, double sideB, double sideC)
        {
            // Arrange
            var triangle = new Triangle(sideA, sideB, sideC);

            // Act
            return triangle.CalculateArea();
        }

        [Test]
        [Category("RightAngleCheck")]
        [TestCase(3, 4, 5, true)] 
        [TestCase(5, 5, 5, false)] 
        [TestCase(5, 12, 13, true)] 
        [TestCase(2, 2, 3, false)]
        public void IsRightAngled_TestVariousTriangles(double sideA, double sideB, double sideC, bool expected)
        {
            // Arrange
            var triangle = new Triangle(sideA, sideB, sideC);

            // Act
            var isRightAngled = triangle.IsRightAngled();

            // Assert
            Assert.That(isRightAngled, Is.EqualTo(expected));
        }

        [Test]
        [Category("ConstructorValidation")]
        [TestCase(0, 4, 5)]
        [TestCase(-1, 2, 3)]
        [TestCase(1, 0, 1)]
        public void Constructor_WithInvalidSides_ThrowsArgumentException(double sideA, double sideB, double sideC)
        {
            // Act & Assert
            Assert.Throws<ArgumentException>(() => new Triangle(sideA, sideB, sideC));
        }

        [Test]
        [Category("EdgeCases")]
        public void CalculateArea_WithVerySmallSides_ReturnsZero()
        {
            // Arrange
            var sideA = double.Epsilon;
            var sideB = double.Epsilon;
            var sideC = double.Epsilon;
            var triangle = new Triangle(sideA, sideB, sideC);

            // Act
            var area = triangle.CalculateArea();

            // Assert
            Assert.That(area, Is.EqualTo(0).Within(1e-20));
        }
    }
}
