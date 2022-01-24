using Shapes_InterFace.Contrcat;
using Shapes_InterFace.Enum;

namespace Shapes_InterFace.Concrete
{
    public class Square : IShapes
    {
        public Square(double side)
        {
            Side = side;
        }
        public string NameOfShape
        {
            get
            {
                return EnShapes.Square.ToString();
            }
        }
        public double Side { get; set; }
        double IShapes.Area()
        {
            var area = Side * Side;
            return area;
        }
        double IShapes.Environment()
        {
            var environment = Side * 4;
            return environment;
        }
    }
}
