using System;
using System.Linq;

namespace AreaCalculator.Figures
{
	public class Triangle : Figure
	{
        /// <summary>
        /// First side of a triangle.
        /// </summary>
        public double FirstSide { get; }

        /// <summary>
        /// Second side of a triangle.
        /// </summary>
        public double SecondSide { get; }

        /// <summary>
        /// Third side of a triangle.
        /// </summary>
        public double ThirdSide { get; }

        /// <summary>
        /// Parameterized constructor.
        /// </summary>
        /// <param name="firstSide">First side of a triangle.</param>
        /// <param name="secondSide">Second side of a triangle.</param>
        /// <param name="thirdSide">Third side of a triangle.</param>
        /// <exception cref="ArgumentOutOfRangeException">Throwing an exception if one of the sides of the triangle is negative.</exception>
        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            if (firstSide < 0 || secondSide < 0 || thirdSide < 0)
            {
                throw new ArgumentOutOfRangeException("The side of the triangle cannot be negative.");
            }

            FirstSide = firstSide;
            SecondSide = secondSide;
            ThirdSide = thirdSide;
        }

        /// <summary>
        /// Calculating the area of ​​a geometric figure.
        /// </summary>
        /// <returns>Figure area.</returns>
        /// <exception cref="InvalidOperationException">Throwing an exception if one of the sides of the triangle is larger than the other two.</exception>
        public override double CalculateArea()
        {
            if (!DasTriangleExists())
            {
                throw new InvalidOperationException("There are not enough points to calculate the area. The number of points must be more than two.");
            }

            var semiPerimeter = (FirstSide + SecondSide + ThirdSide) / 2;

            var firstSideParameter = semiPerimeter - FirstSide;
            var secondSideParameter = semiPerimeter - SecondSide;
            var thirdSideParameter = semiPerimeter - ThirdSide;

            return Math.Sqrt(semiPerimeter * firstSideParameter * secondSideParameter * thirdSideParameter);
        }

        /// <summary>
        /// The method checks if a triangle is rectangular.
        /// </summary>
        /// <returns>True if triangle is rectangular.</returns>
        /// <exception cref="InvalidOperationException">Throwing an exception if one of the sides of the triangle is larger than the other two.</exception>
        public bool IsTriangleRight()
        {
            if (!DasTriangleExists())
            {
                throw new InvalidOperationException("There are not enough points to calculate the area. The number of points must be more than two.");
            }

            bool isRightTriangle;

            double maxSide = GetMaxSide();

            if (maxSide == FirstSide)
            {
                isRightTriangle = maxSide * maxSide == SecondSide * SecondSide + ThirdSide * ThirdSide;
            }
            else if (maxSide == SecondSide)
            {
                isRightTriangle = maxSide * maxSide == FirstSide * FirstSide + ThirdSide * ThirdSide;
            }
            else
            {
                isRightTriangle = maxSide * maxSide == FirstSide * FirstSide + SecondSide * SecondSide;
            }

            return isRightTriangle;
        }

        /// <summary>
        /// Check the existence of a triangle for given sides.
        /// </summary>
        /// <returns>True if each side is less than the sum of the other two</returns>
        public bool DasTriangleExists()
        {
            double maxSide = GetMaxSide();

            return maxSide + maxSide <= FirstSide + SecondSide + ThirdSide;
        }

        /// <summary>
        /// The method returns the maximum side of a triangle.
        /// </summary>
        /// <returns>The maximum side of a triangle.</returns>
        private double GetMaxSide()
        {
            double[] arrayOfSides = { FirstSide, SecondSide, ThirdSide };

            return arrayOfSides.Max();
        }

    }
}
