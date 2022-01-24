using Shapes_InterFace.Contrcat;
using Shapes_InterFace.Enum;

namespace Shapes_InterFace.Concrete
{
    public class Circle : IShapes
    {
        public Circle(double radius)
        {
            Radius = radius;
        }
        public string NameOfShape
        {
            get
            {
                return EnShapes.Circle.ToString();
            }
        }
        private double Pi = 3.14;
        public double Radius { get; set; }
        double IShapes.Area()
        {
            var area = Radius * Radius * Pi;
            return area;
        }
        double IShapes.Environment()
        {
            var environment = Radius * Pi * 2;
            return environment;
        }
    }
}

