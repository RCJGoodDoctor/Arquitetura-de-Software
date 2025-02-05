

namespace Exercicios.Exercicio_2.Violacao
{
    public class AreaCalculator
    {
        public double CalculateArea(object shape)
        {
            if (shape is Rectangle rectangle)
            {
                return rectangle.Width * rectangle.Height;
            }
            else if (shape is Circle circle)
            {
                return Math.PI * Math.Pow(circle.Radius, 2);
            }
            
            throw new ArgumentException("Invalid shape type");
        }
    }

    public class Rectangle
    {
        public double Width { get; set; }
        public double Height { get; set; }
    }

    public class Circle
    {
        public double Radius { get; set; }
    }
}
