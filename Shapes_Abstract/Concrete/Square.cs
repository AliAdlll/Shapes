using Shapes_Abstract.Enums;

namespace Shapes_Abstract.Concrete
{
    public class Square : Shapes
    {
        public Square(double side)
        {
            Side = side;
        }
        public double Side { get; set; }
        public override string NameOfShape
        {
            get
            {
                return EnShapes.Square.ToString();
            }
        }
        public override double Area()
        {
            return Side * Side;
        }
        public override double Environment()
        {
            return Side * 4;
        }
    }
}
