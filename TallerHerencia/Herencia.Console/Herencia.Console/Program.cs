using System.Drawing;

namespace Geometry
{
    class Program
    {
        static void Main(string[] args)
        {
            var circle = new Circle(nameof(Circle), 5);
            var square = new Square(nameof(Square), 10);
            var rhombus = new Rhombus(nameof(Rhombus), 5, 7, 10);
           