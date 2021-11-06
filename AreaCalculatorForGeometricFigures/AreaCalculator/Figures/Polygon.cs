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
		/// <exception cref="InvalidOperationException">Throwing an exception if the count of points is not enough to build a figure.</exception>
		public override double CalculateArea()
		{
			if (Points.Length < 3)
			{
				throw new InvalidOperationException("There are not enough points to calculate the area. The number of points must be more than two.");
			}

			double area = 0;

			for (int i = 0; i < Points.Length; i++)
            {
				if (i == Points.Length - 1)
                {
					area += (Points[i].X * Points[0].Y - Points[0].X * Points[i].Y);
					break;
				}

				area += (Points[i].X * Points[i + 1].Y - Points[i + 1].X * Points[i].Y);
			}

			return Math.Abs(area) * 0.5;
		}
	}
}
