using Shapes_InterFace.Contrcat;
using Shapes_InterFace.Enum;

namespace Shapes_InterFace.Concrete
{
    public class Rectangle : IShapes
    {
        public Rectangle(double lenght, double width)
        {
            Lenght = lenght;
            Width = width;
        }
        public string NameOfShape
        {
            get
            {
                return EnShapes.Rectangle.ToString();
            }
        }
        public double Lenght { get; set; }
        public double Width { get; set; }
        double IShapes.Area()
        {
            var area = Lenght * Width;
            return area;
        }
        double IShapes.Environment()
        {
            var environment = (Lenght + Width) * 2;
            return environment;
        }
    }
}