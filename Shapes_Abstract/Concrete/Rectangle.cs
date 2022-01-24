using Shapes_Abstract.Enums;


namespace Shapes_Abstract.Concrete
{
    public class Rectangle : Shapes
    {
        public Rectangle(double width,double lenght)
        {
            Width = width;
            Lenght = lenght;
        }
        public double Width { get; set; }
        public double Lenght { get; set; }
        public override string NameOfShape
        {
            get
            {
                return EnShapes.Rectangle.ToString();
            }
        }
        public override double Area()
        {
            return Width * Lenght;
        }
        public override double Environment()
        {
            return (Width + Lenght) * 2;
        }
    }
}
