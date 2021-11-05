using System;

namespace AreaCalculator.Primitives
{
	public class Point
	{
		/// <summary>
		/// Point on the X-axis
		/// </summary>
		public double X { get; set; }

		/// <summary>
		/// Point on the Y-axis.
		/// </summary>
		public double Y { get; set; }

		/// <summary>
		/// Parameterized constructor.
		/// </summary>
		/// <param name="x">X-axis point value.</param>
		/// <param name="y">Y-axis point value.</param>
		public Point(double x, double y)
		{
			X = x;
			Y = y;
		}
	}
}
