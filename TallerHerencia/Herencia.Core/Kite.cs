using System.ComponentModel.DataAnnotations;

namespace Geometry
{
	public class Kite : Rhombus
	{
		private double b;
		public double B
		{
			get { return b; }
			set
			{
				ValidateB(value);
				b = value;
			}
		}

		public Kite(string name, double a, double d1, double d2, double b) : base(name, a, d1, d2)
		{
			ValidateB(b);
			B = b;
		}

