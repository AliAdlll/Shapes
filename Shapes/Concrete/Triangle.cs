using Shapes_InterFace.Contrcat;
using Shapes_InterFace.Enum;

namespace Shapes_InterFace.Concrete
{
    public class Triangle : IShapes
    {
        public Triangle(double height, double side)
        {
            Height = height;
            Side = side;
        }
        public string NameOfShape
        {
            get
            {
                return EnShapes.Triangle.ToString();
            }
        }
        public double Height { get; set; }
        public double Side { get; set; }
        double IShapes.Area()
        {
            var area = (Height * Side) / 2;
            return area;
        }
        double IShapes.Environment()
        {
            var environment = Side*3;
            return environment;
        }
    }
}

