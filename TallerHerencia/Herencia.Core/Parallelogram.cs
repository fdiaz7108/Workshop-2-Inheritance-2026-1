namespace Geometry
{
    public class Parallelogram : Rectangle
    {
        private double h;
        public double H
        {
            get { return h; }
            set
            {
                ValidateH(value);
                h = value;
            }
        }

        public Parallelogram(string name, double a, double b, double h) : base(name, a, b)
        {
            ValidateH(h);
            H = h;
        }

        public override double GetArea()
        {
            return B * H;
        }