using System;
using System.Linq;

namespace AreaCalculator.Figures
{
	public class Triangle : Figure
	{
        /// <summary>
        /// First side of a triangle
        /// </summary>
        public double FirstSide { get; }

        /// <summary>
        /// Second side of a triangle
        /// </summary>
        public double SecondSide { get; }

        /// <summary>
        /// Third side of a triangle
        /// </summary>
        public double ThirdSide { get; }

        /// <summary>
        /// Parameterized constructor
        /// </summary>
        /// <param name="firstSide">First side of a triangle</param>
        /// <param name="secondSide">Second side of a triangle</param>
        /// <param name="thirdSide">Third side of a triangle</param>
        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            if (firstSide < 0 || secondSide < 0 || thirdSide < 0)
            {
                throw new ArgumentOutOfRangeException("The side of the triangle cannot be negative");
            }

            FirstSide = firstSide;
            SecondSide = secondSide;
            ThirdSide = thirdSide;
        }

        /// <summary>
        /// Calculating the area of ​​a geometric figure
        /// </summary>
        /// <returns>Figure area</returns>
        protected override double CalculateArea()
        {
            var semiPerimeter = (FirstSide + SecondSide + ThirdSide) / 2;

            var firstSideParameter = semiPerimeter - FirstSide;
            var secondSideParameter = semiPerimeter - SecondSide;
            var thirdSideParameter = semiPerimeter - ThirdSide;

            return Math.Sqrt(semiPerimeter * firstSideParameter * secondSideParameter * thirdSideParameter);
        }

        /// <summary>
        /// The method checks if a triangle is rectangular
        /// </summary>
        /// <returns>True if triangle is rectangular</returns>
        public bool IsRightTriangle()
        {
            double[] arrayOfSides = { FirstSide, SecondSide, ThirdSide };
            
            double maxSide = arrayOfSides.Max();

            bool isRightTriangle;

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
    }
}
