using System;
using System.Linq;
using AreaCalculator.Primitives;

namespace AreaCalculator.Figures
{
	public class Polygon : Figure
	{
		/// <summary>
		/// Points on the coordinate plane.
		/// </summary>
		public Point[] Points { get; set; }

		public Polygon() {}

		/// <summary>
		/// Parameterized constructor.
		/// </summary>
		/// <exception cref="ArgumentOutOfRangeException">Throwing an exception if the radius of the circle is negative.</exception>
		protected override double CalculateArea()
		{
			if (Points.Length < 3)
			{
				throw new ArgumentOutOfRangeException("There are not enough points to calculate the area. The number of points must be more than two.");
			}

			double area = 0;

			var sortedPoints = Points.OrderBy(point => point.X).ThenBy(point => point.Y).ToArray();

			for (int i = 0; i < sortedPoints.Length; i++)
            {
				if (i == sortedPoints.Length - 1)
                {
					area =+ sortedPoints[i].X * sortedPoints[0].Y - sortedPoints[0].X * sortedPoints[i].Y;
					break;
				}

				area =+ sortedPoints[i].X * sortedPoints[i + 1].Y - sortedPoints[i + 1].X * sortedPoints[i].Y;
			}

			return Math.Abs(area) * 0.5;
		}
	}
}
