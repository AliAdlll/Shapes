using Shapes_Abstract.Enums;

namespace Shapes_Abstract.Concrete
{
    public class Circle : Shapes
    {
        public Circle(double radius)
        {
            Radius = radius;
        }
            public double Radius { get; set; }
        public override string NameOfShape
        {
            get
            {
                return EnShapes.Circle.ToString();
            }
        }
        double Pi = 3.14;
        public override double Area()
        {
            return Pi*Radius*Radius;
        }
        public override double Environment()
        {
            return Radius * Pi * 2;
        }
    }
}
