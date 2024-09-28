using GeometryLibrary;

namespace TestGeometryLibrary
{
    [TestFixture]
    public class CircleTests
    {
        [Test]
        [Category("AreaCalculation")]
        [TestCase(1)]
        [TestCase(2.5)]
        [TestCase(5)]
        [TestCase(10)]
        [TestCase(1000)]
        public void CalculateArea_WithPositiveRadius_ReturnsCorrectArea(double radius)
        {
            // Arrange
            var circle = new Circle(radius);
            var expectedArea = Math.PI * radius * radius;

            // Act
            var actualArea = circle.CalculateArea();

            // Assert
            Assert.That(actualArea, Is.EqualTo(expectedArea).Within(1e-10));
        }

        [Test]
        [Category("ConstructorValidation")]
        [TestCase(0)]
        [TestCase(-0.1)]
        [TestCase(-100)]
        public void Constructor_WithNegativeRadius_ThrowsArgumentException(double radius)
        {
            // Act & Assert
            Assert.Throws<ArgumentException>(() => new Circle(radius));
        }

        [Test]
        [Category("EdgeCases")]
        public void CalculateArea_WithVeryLargeRadius_ReturnsInfinity()
        {
            // Arrange
            var radius = double.MaxValue;
            var circle = new Circle(radius);

            // Act
            var area = circle.CalculateArea();

            // Assert
            Assert.IsTrue(double.IsInfinity(area));
        }

        [Test]
        [Category("EdgeCases")]
        public void CalculateArea_WithVerySmallRadius_ReturnsZero()
        {
            // Arrange
            var radius = double.Epsilon;
            var circle = new Circle(radius);
            var expectedArea = Math.PI * radius * radius;

            // Act
            var actualArea = circle.CalculateArea();

            // Assert
            Assert.That(actualArea, Is.EqualTo(expectedArea).Within(1e-20));
        }
    }
}
