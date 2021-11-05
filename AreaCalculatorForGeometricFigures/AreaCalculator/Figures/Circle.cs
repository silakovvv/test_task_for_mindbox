using System;

namespace AreaCalculator.Figures
{
	public class Circle : Figure
	{
		/// <summary>
		/// Circle radius.
		/// </summary>
		public double Radius { get; }

		/// <summary>
		/// Parameterized constructor.
		/// </summary>
		/// <param name="radius">Circle radius.</param>
		/// <exception cref="ArgumentOutOfRangeException">Throwing an exception if the radius of the circle is negative.</exception>
		public Circle(double radius)
		{
			if (radius < 0)
			{
				throw new ArgumentOutOfRangeException("Radius cannot be negative.");
			}				

			Radius = radius;
		}

		/// <summary>
		/// Calculating the area of ​​a geometric figure.
		/// </summary>
		/// <returns>Figure area</returns>
		protected override double CalculateArea()
		{
			return Radius * Radius * Math.PI;
		}
	}
}
