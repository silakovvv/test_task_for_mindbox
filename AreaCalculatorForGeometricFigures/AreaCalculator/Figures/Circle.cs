using System;

namespace AreaCalculator.Figures
{
	public class Circle : Figure
	{
		public double Radius { get; }

		public Circle(double radius)
		{
			if (radius < 0)
			{
				throw new ArgumentOutOfRangeException("Radius cannot be negative");
			}				

			Radius = radius;
		}

		protected override double CalculateArea()
		{
			return Radius * Radius * Math.PI;
		}
	}
}
