using AreaCalculator.Figures;
using AreaCalculator.Primitives;
using NUnit.Framework;
using System;

namespace AreaCalculator.Test
{
    [TestFixture]
    public class AreaCalculatorTest
    {
        [SetUp]
        public void Setup()
        {
        }

        /// <summary>
        /// Testing the calculation of the area of a circle.
        /// </summary>
        [Test]
        public void Circle_CalculateAreaTest()
        {
            //Arrange
            var circle = new Circle(3);

            //Act
            var circleArea = circle.CalculateArea();

            //Assert
            Assert.AreEqual(28.274333882308138, circleArea);
        }

        /// <summary>
        /// Testing the calculation of the area of a circle.
        /// </summary>
        [Test]
        public void Triangle_CalculateAreaTest()
        {
            //Arrange
            var triangle = new Triangle(10, 6, 8);

            //Act
            var triangleArea = triangle.CalculateArea();

            //Assert
            Assert.AreEqual(24, triangleArea);
        }

        /// <summary>
        /// Checking to catch an exception if the triangle does not exist.
        /// </summary>
        [Test]
        public void TriangleExistenceTest()
        {
            //Arrange
            var triangle = new Triangle(12, 7, 4);

            //Act; Assert
            Assert.Throws<InvalidOperationException>(() => triangle.CalculateArea());
        }

        /// <summary>
        /// Check if a triangle is right-angled.
        /// </summary>
        [Test]
        public void RightAngleTriangleTest()
        {
            //Arrange
            var triangle = new Triangle(10, 6, 8);

            //Act
            var isTriangleRight = triangle.IsTriangleRight();

            //Assert
            Assert.AreEqual(true, isTriangleRight);
        }

        /// <summary>
        /// Testing the calculation of the area of a circle.
        /// </summary>
        [Test]
        public void Polygon_CalculateAreaTest()
        {
            //Arrange
            var polygon = new Polygon();
            polygon.Points = new Point[] { 
                new Point(3, 4), new Point(5, 11),
                new Point(12, 8), new Point(9, 4),
                new Point(5, 6) 
            };

            //Act
            var polygonArea = polygon.CalculateArea();

            //Assert
            Assert.AreEqual(33.5, polygonArea);
        }

        /// <summary>
        /// Testing the calculation of the area of ​​a polygon with insufficient number of points.
        /// </summary>
        [Test]
        public void Polygon_AreaCalculationWithInsufficientCountOfPointsTest()
        {
            //Arrange
            var polygon = new Polygon();
            polygon.Points = new Point[] { new Point(3, 4), new Point(5, 11) };

            //Act; Assert
            Assert.Throws<InvalidOperationException>(() => polygon.CalculateArea());
        }
    }
}