namespace Geometry
{
    // Clase
    public class Circle : GeometricFigure
    {
        // CAMPO (Fields)
        private double r;
        // PROPIEDADES (properties)
        public double R
        {

            get { return r; }

            set
            {
                ValidateR(value);
                r = value;
            }
        }

        // CONSTRUCTOR (constructor)
        public Circle(string name, double r) : base(name)
        {
            ValidateR(r);
            R = r;
        }

        // METODO
        public override double GetArea()
        {
            return Math.PI * R * R;
        }

        // METODO
        public override double GetPerimeter()
        {
            return 2 * Math.PI * R;
        }