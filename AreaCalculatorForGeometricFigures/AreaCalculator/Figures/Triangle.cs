using System;
using System.Linq;

namespace AreaCalculator.Figures
{
	public class Triangle : Figure
	{
        public double FirstSide { get; }

        public double SecondSide { get; }

        public double ThirdSide { get; }

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

        protected override double CalculateArea()
        {
            var semiPerimeter = (FirstSide + SecondSide + ThirdSide) / 2;

            var firstSideParameter = semiPerimeter - FirstSide;
            var secondSideParameter = semiPerimeter - SecondSide;
            var thirdSideParameter = semiPerimeter - ThirdSide;

            return Math.Sqrt(semiPerimeter * firstSideParameter * secondSideParameter * thirdSideParameter);
        }

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
