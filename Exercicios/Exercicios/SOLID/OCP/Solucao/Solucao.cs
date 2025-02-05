using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios.Exercicio_2.Solucao
{
  

  
    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public override double Area
        {
            get
            {
                return Width * Height;
            }
        }
    }

    public class Circle : Shape
    {
        public double Radius { get; set; }

        public override double Area {
            get
            {
                return Math.PI * Radius * Radius;
            }
        }
       
    }

    public class Square: Shape
    {
        private int _height;
        private int _width;

        public int Height
        {
            get { return _height; }
            set {
                _height = value;
                    _width = value; }
        }

        public int Width
        {
            get { return _width; }
            set
            {
                _height = value;
                _width = value;
            }
        }


        public override double Area
        {
            get
            {
                return Width * Height;
            }
        }
    }
    public abstract class Shape
    {
        public virtual double Area { get; }
    }

    
}
