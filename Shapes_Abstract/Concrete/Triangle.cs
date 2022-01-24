using Shapes_Abstract.Enums;
namespace Shapes_Abstract.Concrete

{
    public class Triangle : Shapes
    {
        public Triangle(double height,double side)
        {
            Height = height;
            Side = side;
        }
        public double Height { get; set; }
        public double Side { get; set; }
        public override string NameOfShape
        {
            get
            {
                return EnShapes.Triangle.ToString();
            }
        }
        public override double Area()
        {
            return (Height * Side) / 2;
        }
        public override double Environment()
        {
            return Side * 3;
        }
    }
}
