using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeBL
{
    public class Rectangle : GeometricObject
    {
        private double height;
        private double width;
        public double Height {  get { return height; } set { height = value; } }
        public double Width { get { return width; } set { width = value; } }
        public override double Area() {
            return Height * Width;
        
        }
        public override double Perimeter()
        {
            return (Height+Width)/2;
        }
        public Rectangle(double widthvalue, double heightvalue, string colorvalue,bool filledvalue) : base(colorvalue, filledvalue)
        {
            Width = widthvalue;
            Height = heightvalue;
        }
        public override string ToString()
        {
            return Color;
        }
    }
}
